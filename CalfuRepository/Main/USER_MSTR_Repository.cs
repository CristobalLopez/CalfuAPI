using CalfuORM.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalfuDTO.Main;

namespace CalfuRepository.Main
{
    public class USER_MSTR_Repository
    {
        private CalfuEntities context;
        private USER_MSTR _userMstr;
        private List<USER_MSTR_DTO> _listUserMstrDtos;

        public bool UpdateUserMstr(USER_MSTR_DTO dto)
        {
            try
            {
                if (ReferenceEquals(context, null)) context = new CalfuEntities();

                USER_MSTR userMstr = context.USER_MSTR.Where(x => x.USER_ID.Equals(dto.USER_ID)).SingleOrDefault();

                if (!ReferenceEquals(null, userMstr))
                {

                    userMstr.USER_NAME = dto.USER_NAME;
                    userMstr.USER_PASS = dto.USER_PASS;
                    userMstr.USER_NICK = dto.USER_NICK;

                    context.SaveChanges();
                }
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
            
        }

        public bool CreateUserMstr(USER_MSTR_DTO dto)
        {
            try
            {
                var _userMstr = new USER_MSTR();
                _userMstr.USER_NAME = dto.USER_NAME;
                _userMstr.USER_PASS = dto.USER_PASS;
                _userMstr.USER_NICK = dto.USER_NICK;
                context.USER_MSTR.Add(_userMstr);
                context.SaveChanges();
                return true;


            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public bool ExistUserMstrRepository(int id)
        {
            if (ReferenceEquals(context, null)) context = new CalfuEntities();


            USER_MSTR userMstr = context.USER_MSTR.Where(x => x.USER_ID.Equals(id)).SingleOrDefault();

            if (!ReferenceEquals(userMstr, null))
                return true;
            else
                return false;
        }
        public USER_MSTR_DTO GetUserMstrRepository(int id)
        {
            try
            {
                USER_MSTR_DTO getUserMstrDto = new USER_MSTR_DTO();
                _userMstr = context.USER_MSTR.Where(x => x.USER_ID.Equals(id)).FirstOrDefault();

                getUserMstrDto.USER_ID = _userMstr.USER_ID;
                getUserMstrDto.USER_NAME = _userMstr.USER_NAME;
                getUserMstrDto.USER_PASS = _userMstr.USER_PASS;
                getUserMstrDto.USER_NICK = _userMstr.USER_NICK;

                //OBRA_MSTR_DTO getObraMstrDto = context.OBRA_MSTR.Where(x => x.OBRA_ID.Equals(id)).ProjectTo<OBRA_MSTR_DTO>().FirstOrDefault();

                return getUserMstrDto;
            }
            catch (Exception ex)
            {

                return null;
            }
            
        }

        public bool LoginByName(string nick, string pass)
        {
            try
            {
                if (ReferenceEquals(context, null)) context = new CalfuEntities();


                USER_MSTR userMstr = context.USER_MSTR.Where(x => x.USER_NICK.Equals(nick) && x.USER_PASS.Equals(pass)).FirstOrDefault();

                if (ReferenceEquals(userMstr, null))
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {

                return false;
            }

            
        }

        public List<USER_MSTR_DTO> SelectUserMstrRepository()
        {
            try
            {
                _listUserMstrDtos = new List<USER_MSTR_DTO>();
                if (ReferenceEquals(context, null)) context = new CalfuEntities();

                _listUserMstrDtos = (from userMstrbd in context.USER_MSTR
                                     select new USER_MSTR_DTO
                                     {
                                         USER_ID = userMstrbd.USER_ID,
                                         USER_NAME = userMstrbd.USER_NAME,
                                         USER_PASS = userMstrbd.USER_PASS,
                                         USER_NICK= userMstrbd.USER_NICK
                                     }).OrderBy(x => x.USER_ID).ToList();
                return _listUserMstrDtos;
            }
            catch (Exception ex)
            {

                return null;
            }
           
        }

        public bool DeleteUserMstrRepository(int id)
        {
            try
            {
                if (ReferenceEquals(context, null)) context = new CalfuEntities();


                USER_MSTR userMstr = context.USER_MSTR.Where(x => x.USER_ID.Equals(id)).SingleOrDefault();

                if (!ReferenceEquals(userMstr, null))
                {
                    context.USER_MSTR.Remove(userMstr);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
            
        }


    }
}
