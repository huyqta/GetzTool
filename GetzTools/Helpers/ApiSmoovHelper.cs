using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GetzTools.Helpers
{
    public static class ApiSmoovHelper
    {
        public static string Sign(Dictionary<string, string> data, string secret)
        {
            // Sort data by Key
            data = data.OrderBy(d => d.Key).ToDictionary(d => d.Key, d => d.Value);
            // Construct the string
            var retSign = data.Where(item => item.Key != "signature").Aggregate("", (current, item) => current + string.Format("{0}={1}", item.Key, item.Value));
            // Append secret and hash using MD5
            var sourceMd5 = retSign + secret;
            using (var mD5 = MD5.Create())
            {
                retSign = GetMd5Hash(mD5, sourceMd5);
                return retSign;
            }
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Create a new Stringbuilder to collect the bytes 
            // and create a string.
            var sBuilder = new StringBuilder();

            if (md5Hash != null)
            {
                // Convert the input string to a byte array and compute the hash. 
                var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Loop through each byte of the hashed data  
                // and format each one as a hexadecimal string. 
                foreach (var t in data)
                {
                    sBuilder.Append(t.ToString("x2"));
                }
            }
            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }

        public static string GenerateStringPost(Dictionary<string, string> data)
        {
            data = data.OrderBy(d => d.Key).ToDictionary(d => d.Key, d => d.Value);

            string postData = data.Aggregate("",
                (current, item) => current + string.Format("{0}={1}&", item.Key, item.Value));

            postData = postData.Substring(0, postData.Length - 1);

            return postData;
        }

        //public static string SetMerchantCode(SQLDomain.Merchant merchant, IMerchantService merchantService)
        //{
        //    if (merchant != null && merchantService != null)
        //    {
        //        merchant.merchantCode = GetRandomHexNumber(4);
        //        var criteria = new MerchantCriteria() { };
        //        criteria.Paging = new Paging() { pageGoTo = 1, limit = 10000 };
        //        var totalRecord = 0;
        //        var listMerchant = merchantService.Search(criteria, ref totalRecord);
        //        var list = listMerchant.Where(m => m.merchantID != merchant.merchantID).ToList();
        //        if (list.Any(
        //                m => m.merchantCode == merchant.merchantCode))
        //        {
        //            return SetMerchantCode(merchant, merchantService);
        //        }
        //        return merchant.merchantCode;
        //    }

        //    return string.Empty;
        //}

        //public static string GetRandomHexNumber(int digits)
        //{
        //    Random random = new Random();
        //    byte[] buffer = new byte[digits / 2];
        //    random.NextBytes(buffer);
        //    string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
        //    if (digits % 2 == 0)
        //        return result;
        //    return result + random.Next(16).ToString("X");
        //}
        //public static string SetStoreCode(Inventory inventory, IInventoryService inventoryService)
        //{
        //    if (inventory != null && inventoryService != null)
        //    {
        //        inventory.storeCode = GetRandomHexNumber(3);
        //        var listStores = inventoryService.GetAll(inventory.bucket);
        //        var list = listStores.Where(m => m.storeCode != inventory.storeCode).ToList();
        //        if (list.Any(
        //                 m => m.storeCode == inventory.storeCode))
        //        {
        //            return SetStoreCode(inventory, inventoryService);
        //        }
        //        return inventory.storeCode;
        //    }
        //    return string.Empty;
        //}
    }
}
