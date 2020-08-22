using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalfuDTO.Main;
using CalfuORM.Main;

namespace CalfuRepository.Main
{
    public class OBRA_MSTR_Repository
    {
        private CalfuEntities context;
        private OBRA_MSTR _obraMstr;
        private List<OBRA_MSTR_DTO> _listObraMstrDtos;


        public bool UpdateObraMstr(OBRA_MSTR_DTO dto)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
            if (ReferenceEquals(context, null)) context = new CalfuEntities();

            OBRA_MSTR obraMstr = context.OBRA_MSTR.Where(x => x.OBRA_ID.Equals(dto.OBRA_ID)).SingleOrDefault();

            if (!ReferenceEquals(null, obraMstr))
            {

                obraMstr.ALIAS = dto.ALIAS;
                obraMstr.ANCHO = dto.ANCHO;
                obraMstr.DESCRIPCION = dto.DESCRIPCION;
                obraMstr.FILE_NAME = dto.FILE_NAME;
                obraMstr.ME_GUSTA = dto.ME_GUSTA;
                obraMstr.NO_ME_GUSTA = dto.NO_ME_GUSTA;
                obraMstr.TIPO_OBRA_ID = dto.TIPO_OBRA_ID;
                context.SaveChanges();
            }
            context.SaveChanges();
            return true;
        }

        public bool CreateObraMstr(OBRA_MSTR_DTO dto)
        {
            try
            {
                var _obraMstr = new OBRA_MSTR();
                _obraMstr.ALIAS = dto.ALIAS;
                _obraMstr.ANCHO = dto.ANCHO;
                _obraMstr.DESCRIPCION = dto.DESCRIPCION;
                _obraMstr.FILE_NAME = dto.FILE_NAME;
                _obraMstr.ME_GUSTA = dto.ME_GUSTA;
                _obraMstr.NO_ME_GUSTA = dto.NO_ME_GUSTA;
                _obraMstr.TIPO_OBRA_ID = dto.TIPO_OBRA_ID;
                context.OBRA_MSTR.Add(_obraMstr);
                context.SaveChanges();
                return true;


            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public bool ExistObraMstrRepository(int id)
        {
            
                if (ReferenceEquals(context, null)) context = new CalfuEntities();


                OBRA_MSTR obraMstr = context.OBRA_MSTR.Where(x => x.OBRA_ID.Equals(id)).SingleOrDefault();

                if (ReferenceEquals(obraMstr, null))
                    return true;
                else
                    return false;
            
            
        }
        public OBRA_MSTR_DTO GetObraMstrRepository(int id)
        {
            OBRA_MSTR_DTO getObraMstrDto = new OBRA_MSTR_DTO();
            if (ReferenceEquals(context, null)) context = new CalfuEntities();
            try
            {
                _obraMstr = new OBRA_MSTR();
                _obraMstr = context.OBRA_MSTR.Where(x => x.OBRA_ID.Equals(id)).FirstOrDefault();

                getObraMstrDto.OBRA_ID = _obraMstr.OBRA_ID;
                getObraMstrDto.ALIAS = _obraMstr.ALIAS;
                getObraMstrDto.ANCHO = _obraMstr.ANCHO;
                getObraMstrDto.DESCRIPCION = _obraMstr.DESCRIPCION;
                getObraMstrDto.FILE_NAME = _obraMstr.FILE_NAME;
                getObraMstrDto.ME_GUSTA = _obraMstr.ME_GUSTA;
                getObraMstrDto.NO_ME_GUSTA = _obraMstr.NO_ME_GUSTA;
                getObraMstrDto.TIPO_OBRA_ID = _obraMstr.TIPO_OBRA_ID;

                //OBRA_MSTR_DTO getObraMstrDto = context.OBRA_MSTR.Where(x => x.OBRA_ID.Equals(id)).ProjectTo<OBRA_MSTR_DTO>().FirstOrDefault();

                return getObraMstrDto;
            }
            catch (Exception ex)
            {

                return null;
            }
            
        }

        public List<OBRA_MSTR_DTO> SelectObrasMstrRepository()
        {
            try
            {
                _listObraMstrDtos = new List<OBRA_MSTR_DTO>();
                if (ReferenceEquals(context, null)) context = new CalfuEntities();

                _listObraMstrDtos = (from obraMstrbd in context.OBRA_MSTR
                                     select new OBRA_MSTR_DTO
                                     {
                                         OBRA_ID = obraMstrbd.OBRA_ID,
                                         ALIAS = obraMstrbd.ALIAS,
                                         ANCHO = obraMstrbd.ANCHO,
                                         DESCRIPCION = obraMstrbd.DESCRIPCION,
                                         FILE_NAME = obraMstrbd.FILE_NAME,
                                         ME_GUSTA = obraMstrbd.ME_GUSTA,
                                         NO_ME_GUSTA = obraMstrbd.NO_ME_GUSTA,
                                         TIPO_OBRA_ID = obraMstrbd.TIPO_OBRA_ID
                                     }).OrderBy(x => x.OBRA_ID).ToList();
                return _listObraMstrDtos;
            }
            catch (Exception ex)
            {

                return null;
            }
            
        }

        public bool DeleteObraMstrRepository(int id)
        {
            try
            {
                if (ReferenceEquals(context, null)) context = new CalfuEntities();


                OBRA_MSTR obraMstr = context.OBRA_MSTR.Where(x => x.OBRA_ID.Equals(id)).SingleOrDefault();

                if (!ReferenceEquals(obraMstr, null))
                {
                    context.OBRA_MSTR.Remove(obraMstr);
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

        public List<OBRA_MSTR_DTO> SelectTop5ObrasMstrRepository()
        {
            try
            {
                _listObraMstrDtos = new List<OBRA_MSTR_DTO>();
                if (ReferenceEquals(context, null)) context = new CalfuEntities();

                _listObraMstrDtos = (from obraMstrbd in context.OBRA_MSTR
                                     select new OBRA_MSTR_DTO
                                     {
                                         OBRA_ID = obraMstrbd.OBRA_ID,
                                         ALIAS = obraMstrbd.ALIAS,
                                         ANCHO = obraMstrbd.ANCHO,
                                         DESCRIPCION = obraMstrbd.DESCRIPCION,
                                         FILE_NAME = obraMstrbd.FILE_NAME,
                                         ME_GUSTA = obraMstrbd.ME_GUSTA,
                                         NO_ME_GUSTA = obraMstrbd.NO_ME_GUSTA,
                                         TIPO_OBRA_ID = obraMstrbd.TIPO_OBRA_ID
                                     }).OrderByDescending(x => x.ME_GUSTA).Take(5).ToList();
                return _listObraMstrDtos;
            }
            catch (Exception ex)
            {

                return null;
            }
            
        }

    }
}
