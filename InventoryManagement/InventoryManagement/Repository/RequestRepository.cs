﻿using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Repository
{
    public class RequestRepository : BaseRepository
    {
        public int InsertNewRequest(RequestViewModel req)
        {
            var newReq = new Request
            {
                request_date = req.RequestedDate,
                requested_by_id = req.RequestedById,
                request_item_type = (int)req.RequestItemType,
                request_status = (int)req.RequestedStatus,
                user_id = req.UserId,
                request_type = (int)req.RequestType
            };
            InventoryDatabase.Requests.Add(newReq);
            if (InventoryDatabase.SaveChanges() > 0)
                return newReq.id;
            else
                return 0;
        }
        public List<RequestViewModel> GetRequestByUserId(int userId)
        {
            var result = new List<RequestViewModel>();
            var reqs = InventoryDatabase.Requests.Where(x => x.user_id == userId);
            foreach(Request r in reqs)
            {
                result.Add(new RequestViewModel {
                    Id = r.id,
                    ProcessDate = r.process_date ?? DateTime.MinValue,
                    ProcessedById = r.process_by_id ??0,
                    RequestedById = r.requested_by_id,
                    RequestedDate = r.request_date,
                    RequestedStatus = (RequestStatus)r.request_status,
                    RequestItemType = (PrimaryItemType)r.request_item_type,
                    RequestSecondaryItemType = (SecondaryItemType)r.request_item_type,
                    RequestType = (RequestType)r.request_type,
                    Remarks = r.remarks,
                    UserId = r.user_id
                });
            }
            return result;
        }
        public bool UpdateRequest(RequestViewModel req)
        {
            var oldRequest = InventoryDatabase.Requests.FirstOrDefault(x=> x.id == req.Id);
            if(oldRequest != null)
            {
                oldRequest.process_by_id = req.ProcessedById;
                oldRequest.process_date = req.ProcessDate;
                oldRequest.request_status = (int)req.RequestedStatus;
                InventoryDatabase.SaveChanges();

                return true;
            }
            return false;
            
        }
    }
}