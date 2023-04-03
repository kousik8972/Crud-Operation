using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud_Operation.CommonLayer.Model;
using Crud_Operation.RepositoryLayer;

namespace Crud_Operation.ServiceLayer
{
    public class CrudOperationSL : ICrudOperationSL
    {
        public readonly ICrudOperationRL _CrudOperationRL;
        public CrudOperationSL(ICrudOperationRL crudOperationRL)
        {
            _CrudOperationRL = crudOperationRL;
        }
        public async Task<CreateRecordResponse> CreateRecord(CreateRecordRequest request)
        {
            return await _CrudOperationRL.CreateRecord(request);
        }

        public async Task<DeleteRecordResponse> DeleteRecord(DeleteRecordRequest request)
        {
            return await _CrudOperationRL.DeleteRecord(request);
        }

        public async Task<ReadRecordResponse> ReadRecord()
        {
            return await _CrudOperationRL.ReadRecord();
            
        }

        public async Task<UpdateRecordResponse> UpdateRecord(UpdateRecordRequest recordRequest)
        {
            return await _CrudOperationRL.UpdateRecord(request);
        }
    }

}