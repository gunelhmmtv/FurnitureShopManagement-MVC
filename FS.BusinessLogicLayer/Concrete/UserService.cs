using AutoMapper;
using FluentValidation;
using FS.BusinessLogicLayer.Abstract;
using FS.BusinessLogicLayer.Dtos;
using FS.BusinessLogicLayer.ValidationRules;
using FS.CoreLayer.Classes;
using FS.CoreLayer.Enums;
using FS.CoreLayer.Extentions;
using FS.CoreLayer.Helpers;
using FS.CoreLayer.Wrappers.Implementations;
using FS.CoreLayer.Wrappers.Interfaces;
using FS.DataAccessLayer.Abstract;
using FS.DataAccessLayer.EntityFrameworkCore.Concrete;
using FS.Entity.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.BusinessLogicLayer.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserDetailRepository _userDetailRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateUserDto> _createUserDtoValidator;

        public UserService(IUserRepository userRepository,
                           IUserDetailRepository userDetailRepository,
                           IValidator<CreateUserDto> createUserDtoValidator,
                           IMapper mapper)
        {
            _userRepository = userRepository;
            _userDetailRepository = userDetailRepository;
            _createUserDtoValidator = createUserDtoValidator;
            _mapper = mapper;
        }

        public async Task<IResponseDataResult<RegisterUserDto>> CreateUserAsync(CreateUserDto userDto)
        {
           var validationResult = await _createUserDtoValidator.ValidateAsync(userDto);
           if(validationResult.IsValid is false)
            {
                return new ResponseDataResult<RegisterUserDto>(validationResult.ToResponseValidationResults());
            }
            var user = _userRepository
                 .GetWhereAsync(x => x.Email == userDto.Email)
                 .Any();

            if(user is true)
            {
                return new ResponseDataResult<RegisterUserDto>(new List<ResponseValidationResult>
                {
                    new()
                    {
                        ErrorMessage = "Email is registered int the system",
                        PropertyName= "Email"
                    }
                });
            }

            var userEntity = _mapper.Map<User>(userDto);
            userEntity.UserDetail=_mapper.Map<UserDetail>(userDto);


            byte[] passwordHash;
            byte[] passwordSalt;


            HashHelper.CreatePasswordHash(userDto.Password, out passwordHash, out passwordSalt);

            userEntity.PassworHash = passwordHash.ByteToString();
            userEntity.PasswordSalt = passwordSalt.ByteToString();

            userEntity.UserDetail.ConfirmCode = GeneratorHelper.GeneratorConfirmCode();
            userEntity.UserDetail.StatusId = (int)RegisterStatusEnum.RegisterUser;
            userEntity.UserRoles =
               [
                   new() { RoleId = 1 }
               ];
            await _userRepository.AddAsync(userEntity);
            try
            {
                await _userRepository.SaveChangesAsync();

            }
            catch (Exception E)
            {
                var EM = E;
                                
            }
            return new ResponseDataResult<RegisterUserDto>( new RegisterUserDto()
            {
                Id = userEntity.Id,
                Email=userEntity.Email,
                ConfirmCode=userEntity.UserDetail.ConfirmCode,
                FirstName=userEntity.UserDetail.FirstName,
                LastName=userEntity.UserDetail.LastName,

            });
        }
    }
}

