﻿using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Repository
{
    public class ItemRepository : BaseRepository
    {
        public object ItemModel { get; internal set; }

        public int Insert(ItemViewModel newItem, int userId)
        {
           
            var itm = new Item
            {
                name = newItem.Name,
                brand_id = newItem.BrandId,
                description = newItem.Description,
                item_sub_type_id = (int)newItem.SubTypeId,
                item_type_id = (int)newItem.TypeId,
                last_updated = newItem.LastUpdatedDate,
                last_updated_user = newItem.LastUpdatedUserId,
                life_span = newItem.LifeSpan,
                model = newItem.Model,
                purchase_date = newItem.PurchaseDate,
                purchase_price = newItem.PurchasePrice,
                current_value = newItem.Currentvalue,
                current_owner = newItem.CurrentOwner,
                serial = newItem.Serial,
                status = (int)newItem.Status,
                asset_tag = newItem.AssetTag,
                os_id = (int)newItem.OS,
                processor_id = (int)newItem.Processor,
                memory_id = (int)newItem.Memory,
                hdd1_id = (int)newItem.HDD1,
                hdd2_id = (int)newItem.HDD2,

            };
            InventoryDatabase.Items.Add(itm);

            InventoryDatabase.SaveChanges();

            return itm.id;
        }
        public bool Update(ItemViewModel newItem, int userId)
        {
            var item = InventoryDatabase.Items.FirstOrDefault(h => h.id == newItem.Id);

            if(item != null)
            {
                item.name = newItem.Name;
                item.brand_id = newItem.BrandId;
                item.description = newItem.Description;
                item.item_sub_type_id = (int)newItem.SubTypeId;
                item.item_type_id = (int)newItem.TypeId;
                item.last_updated = newItem.LastUpdatedDate;
                item.last_updated_user = newItem.LastUpdatedUserId;
                item.life_span = newItem.LifeSpan;
                item.model = newItem.Model;
                item.purchase_date = newItem.PurchaseDate;
                item.purchase_price = newItem.PurchasePrice;
                item.current_value = newItem.Currentvalue;
                item.current_owner = newItem.CurrentOwner;
                item.serial = newItem.Serial;
                item.status = (int)newItem.Status;
                item.os_id = (int)newItem.OS;
                item.processor_id = (int)newItem.Processor;
                item.memory_id = (int)newItem.Memory;
                item.hdd1_id = (int)newItem.HDD1;
                item.hdd2_id = (int)newItem.HDD2;

                InventoryDatabase.SaveChanges();

                return true;
            }

            return false;
        }

        public bool UpdateItemStatus(int subtypeId, ItemStatus status)
        {

            var item = InventoryDatabase.Items.FirstOrDefault(x => x.item_sub_type_id == subtypeId && x.status == 0);
            if (item != null)
            {
                item.status = 2;
                InventoryDatabase.SaveChanges();

                return true;
            }
            return false;

        }
        public bool AttachAssetTag(int itemId, string assetTag)
        {
            var item = InventoryDatabase.Items.FirstOrDefault(h => h.id == itemId);

            if (item != null)
            {
                item.asset_tag = assetTag;
                InventoryDatabase.SaveChanges();

                return true;
            }
            return false;
        }
        public bool UpdateItemStatus(int itemId, int userId, int itemStatus)
        {
            //var item = InventoryDatabase.Items.FirstOrDefault(h => h.id == itemId);
            var item = InventoryDatabase.Items.FirstOrDefault(x => x.id == itemId);

            if (item != null)
            {
                item.status = itemStatus;
                item.current_owner = userId;
                InventoryDatabase.SaveChanges();

                return true;
            }
            return false;
        }

        #region --- Queries ---
        public List<BrandViewModel> QueryBrands()
        {
            var brands = InventoryDatabase.Brands.ToList();
            List<BrandViewModel> bList = new List<BrandViewModel>();

            foreach (Brand b in brands)
            {
                bList.Add(new BrandViewModel { Brand_Id = b.id, SubId = b.subtype_id, Name = b.name });
            }
            return bList;
        }

        public List<BrandViewModel> GetBrandsBySubtype(int subtypeId)
        {
            var brandslist = new List<BrandViewModel>();

            var brands = InventoryDatabase.Brands.Where(x => x.subtype_id == subtypeId).ToList();
            foreach (Brand b in brands)
            {
                brandslist.Add(new ViewModel.BrandViewModel
                {
                    Brand_Id = b.id,
                    SubId = b.subtype_id,
                    Name = b.name,
                });
            }

            return brandslist;
        }
        public BrandViewModel QueryBrand(int id)
        {
            var brands = InventoryDatabase.Brands.FirstOrDefault(h => h.id == id);

            if (brands != null)
            {
                return new BrandViewModel
                {
                    Brand_Id = brands.id,
                    SubId = brands.subtype_id,
                    Name = brands.name
                };
            }
            return null;
        }

        public List<OSViewModel> QueryOSBySubtype(int subtypeId)
        {
            var OSList = new List<OSViewModel>();

            var operatingsystems = InventoryDatabase.OperatingSystems.Where(x => x.subtype_id == subtypeId).ToList();
            foreach (OperatingSystem o in operatingsystems)
            {
                OSList.Add(new ViewModel.OSViewModel
                {
                    OS_Id = o.id,
                    SubtypeId = o.subtype_id,
                    OSName = o.OS,
                });
            }

            return OSList;
        }

        public List<ItemViewModel> QueryItems()
        {
            var items = InventoryDatabase.Items.ToList();
            List<ItemViewModel> iList = new List<ItemViewModel>();

            foreach (Item i in items)
            {
                iList.Add(new ItemViewModel
                {
                    Id = i.id,
                    AssetTag = i.asset_tag,
                    Name = i.name,
                    Description = i.description,
                    TypeId = Convert.ToInt32(i.item_type_id),
                    //Type = i.ItemType.type,
                    SubTypeId = Convert.ToInt32(i.item_sub_type_id),
                    //SubType = i.ItemSubtype.subtype,
                    BrandId = i.brand_id ?? 13,
                    Model = i.model,
                    Serial = i.serial,
                    Status = (ItemStatus)i.status,
                    CurrentOwner = i.current_owner ?? 0,
                    LastUpdatedDate = i.last_updated ?? DateTime.MinValue,
                    PurchaseDate = i.purchase_date ?? DateTime.MinValue,
                    PurchasePrice = i.purchase_price,
                    LifeSpan = i.life_span ?? 5,
                    Currentvalue = i.current_value
                });
            }
            return iList;
        }
        public ItemViewModel QueryItem(int id)
        {
            var i = InventoryDatabase.Items.FirstOrDefault(h => h.id == id);

            return new ItemViewModel
            {
                Id = i.id,
                AssetTag = i.asset_tag,
                Name = i.name,
                Description = i.description,
                TypeId = i.item_type_id,
                //Type = i.ItemType.type,
                SubTypeId = i.item_sub_type_id,
                //SubType = i.ItemSubtype.subtype,
                BrandId = i.brand_id ?? 13,
                Model = i.model,
                Serial = i.serial,
                Status = (ItemStatus)i.status,
                CurrentOwner = i.current_owner ?? 0,
                LastUpdatedDate = i.last_updated ?? DateTime.MinValue,
                PurchaseDate = i.purchase_date ?? DateTime.MinValue,
                PurchasePrice = i.purchase_price,
                LifeSpan = i.life_span ?? 5,
                Currentvalue = i.current_value,
                OS = (int)(i.os_id ?? 0),
                Processor = (ItemProcessors)(i.processor_id ?? 0),
                Memory = (ItemMemory)(i.memory_id ?? 0),
                HDD1 = (ItemHDDCapacity)(i.hdd1_id ?? 0),
                HDD2 = (ItemHDDCapacity)(i.hdd2_id ?? 0),
            };
        }
        public string QueryOwner(int id)
        {
            var user = InventoryDatabase.Users.FirstOrDefault(h => h.id == id);
            if (user != null)
            {
                return user.last_name + ", " + user.first_name;
            }
            else
            {
                return "System";
            }
        }
        #endregion

    }
}
