using Business.Requests.Model;
using Business.Responses.Model;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IModelService

    {
        public GetModelListResponse GetList(GetModelListRequest request);
        public GetModelByIdResponse GetById(GetModelByIdRequest request);
        public AddModelResponse Add(AddModelRequest request);
        public UpdateModelResponse Update(UpdateModelRequest request);
        public DeleteModelResponse Delete(DeleteModelRequest request);

        

        // Brand, Fuel ve Transmission'a göre listeleme işlemi yapılıyor

        /*
       
        public GetModelListResponse GetListByBrand(GetModelListRequestByBrand request);
        public GetModelListResponse GetListByFuel(GetModelListRequestByFuel request);
        public GetModelListResponse GetListByTransmission(GetModelListRequestByTransmission request);
        
         */
    }
}