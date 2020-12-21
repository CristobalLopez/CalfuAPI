using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CalfuDTO.Main;
using CalfuRepository.Main;

namespace CalfuWebApi.Controllers.Main
{
    public class ObraMstrController : ApiController
    {
        OBRA_MSTR_Repository _obraMstrRepository;

        [HttpPost]
        [Route("api/AddObra/")]
        public IHttpActionResult AddObra(OBRA_MSTR_DTO obraDto)
        {
            string retorno = "";
            _obraMstrRepository = new OBRA_MSTR_Repository();

            if (_obraMstrRepository.ExistObraMstrRepository(obraDto.OBRA_ID))
            {
                retorno = _obraMstrRepository.UpdateObraMstr(obraDto) ? "Exito" : "Error";
            }
            else
            {
                retorno = _obraMstrRepository.CreateObraMstr(obraDto) ? "Exito" : "Error";
            }

            return Ok(retorno);
        }
                
        [HttpGet]
        [Route("api/SelectTodasObras/")]        
        public List<OBRA_MSTR_DTO> SelectObras()
        {
            
            _obraMstrRepository = new OBRA_MSTR_Repository();
            return _obraMstrRepository.SelectObrasMstrRepository();
             
        }

        [HttpGet]
        [Route("api/GetObra/")]
        public OBRA_MSTR_DTO GetObra(string id)
        {
            int obraid = 0;
            int.TryParse(id, out obraid);
            _obraMstrRepository = new OBRA_MSTR_Repository();
            return _obraMstrRepository.GetObraMstrRepository(obraid);

        }

        [HttpPut]
        [Route("api/UpdateObra/")]
        public IHttpActionResult UpdateObra(OBRA_MSTR_DTO obraDto)
        {
            string retorno = "";
            _obraMstrRepository = new OBRA_MSTR_Repository();

            retorno = _obraMstrRepository.UpdateObraMstr(obraDto) ? "Exito" : "Error";

            return Ok(retorno);
        }

        [HttpGet]
        [Route("api/RemoveObra/")]
        public string RemoveObra(int id)
        {
            string retorno = "";
            //int obraid = 0;
            //int.TryParse(id, out obraid);
            _obraMstrRepository = new OBRA_MSTR_Repository();

            retorno = _obraMstrRepository.DeleteObraMstrRepository(id) ? "Exito" : "Error";

            return retorno;
        }

        [HttpGet]
        [Route("api/TopFiveObras/")]
        public List<OBRA_MSTR_DTO> SelectTop5Obras()
        {

            _obraMstrRepository = new OBRA_MSTR_Repository();
            return _obraMstrRepository.SelectTop5ObrasMstrRepository();

        }
    }
}
