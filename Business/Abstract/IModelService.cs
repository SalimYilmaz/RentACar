using Business.Requests.Model;
using Business.Responses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IModelService

    {
        // Brand, Fuel ve Transmission'a göre listeleme yapılması işlemi
        public AddModelResponse Add(AddModelRequest request);
        public GetModelListResponse GetList(GetModelListRequest request);


        public GetModelListResponse GetListByBrand(GetModelListRequestByBrand request);
        public GetModelListResponse GetListByFuel(GetModelListRequestByFuel request);
        public GetModelListResponse GetListByTransmission(GetModelListRequestByTransmission request);

    }
}