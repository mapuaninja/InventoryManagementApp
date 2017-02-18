﻿using InventoryManagement.Repository;
using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class ItemModel : BaseModel
    {
        CategoryRepository catRepository;
        ItemRepository itemRepostory;
        SubCategoryRepository catSubRepository;

        public ItemModel()
        {
            catRepository = new CategoryRepository();
            itemRepostory = new ItemRepository();
            catSubRepository = new SubCategoryRepository();
        }
        public ReturnValueModel CreateNewItem(ItemViewModel newItem, int userId)
        {
            var rv = new ReturnValueModel();
            var newItemId = itemRepostory.Insert(newItem, userId);


            var catRepo = new CategoryRepository();
            var itemType = catRepo.QueryCategory(newItem.TypeId);
            var itemSubtype = catSubRepository.QuerySubcategory(newItem.SubTypeId);


            var assetTag = GenerateAssetTag(itemType.Name, itemSubtype.Name, newItemId);

            rv.Success = itemRepostory.AttachAssetTag(newItemId, assetTag);
            if (rv.Success)
            {
                rv.Param1 = newItemId.ToString();
                rv.Param2 = assetTag;
            }

            return rv;
        }
        public ReturnValueModel UpdateItem(ItemViewModel newItem, int userId)
        {
            var rv = new ReturnValueModel();
            rv.Success = itemRepostory.Update(newItem, userId);

            if (rv.Success)
            {
               
            }

            return rv;
        }
        public ReturnValueModel UpdateItemStatus(int itemId, int userId, ItemStatus itemStatus)
        {
            var result = new ReturnValueModel();

            var success = itemRepostory.UpdateItemStatus(itemId, userId, (int)itemStatus);

            result.Success = success;
            //result.Param1 = itemStatus.ToString();

            return result;
        }

        public bool UpdateItemStatusBySubtype(int id, int requestedby)
        {
            return itemRepostory.UpdateItemStatusBySubtype(id, requestedby, ItemStatus.Available);
        }

        public bool UpdateItemStatusById(int id, ItemStatus status)
        {
            return itemRepostory.UpdateItemStatusById(id, status);
        }
        public bool UpdateItemOwner(int id, int owner)
        {
            return itemRepostory.UpdateOwnerByStatus(id, owner);
        }
        public int createOS(int id, string name)
        {
            return itemRepostory.CreateOS(id, name);
        }
        public int UpdateOs(int id, string name)
        {
            return itemRepostory.UpdateOS(id, name);
        }

        public string GenerateAssetTag(string type, string subType, int itemId)
        {
            return type.Substring(0, 1).ToUpper() + subType.Substring(0, 2).ToUpper() + itemId.ToString("D8");
        }
        public List<BrandViewModel> GetBrandsBySubtype(int subtypeId)
        {
            return itemRepostory.GetBrandsBySubtype(subtypeId);
        }

        public List<BrandViewModel> GetBrands()
        {
            return itemRepostory.QueryBrands();
        }


        public List<ItemViewModel> GetItems()
        {
            return itemRepostory.QueryItems();
        }
        public ItemViewModel GetItem(int id)
        {
            //get value from two tables
            
            var item = itemRepostory.QueryItem(id);
            var subcateg = catSubRepository.QuerySubcategory(item.SubTypeId).Name;
            var categ = catRepository.QueryCategory(item.TypeId).Name;
            item.Brand = itemRepostory.QueryBrand(item.BrandId).Name;
            item.SubType = subcateg;
            item.Type = categ;
            item.CurrentOwnerName = itemRepostory.QueryOwner(item.CurrentOwner);

            return item;
        }

        public List<OSViewModel> GetOSBySubtype(int subtypeId)
        {
            return itemRepostory.QueryOSBySubtype(subtypeId);
        }

    }
}
