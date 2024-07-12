using System.Globalization;
using System.Text.RegularExpressions;
using DTC.DefaultRepository.Constants;
using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.Helpers;
using MongoDB.Bson;
using Project.Net8.Models.Core;

namespace Project.Net8.Constants
{
    public static class Validation
    {
        internal static bool  IsCccd_Cmnd(string pText)
        {
            if (pText == null)
                return false;
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            if (pText.Length < 8 || pText.Length > 12 )
            {
                return false;
            }
            return true;
        }
        
        internal static bool  Is_Number(string pText, int length)
        {
            if (pText == null)
                return false;
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            if (!regex.IsMatch(pText) || pText.Length != length)
            {
                return false;
            }
            return true;
        }
        
        internal static bool IsDateValid(DateTime? date)
        {
            DateTime result;
            if (date == null) return false;
            if (date?.ToLocalTime().Year < 1900)
            {
                return false; 
            }
           return  DateTime.TryParseExact(date?.ToLocalTime().ToString(FormatTime.FORMAT_DATE), FormatTime.FORMAT_DATE, CultureInfo.InvariantCulture, DateTimeStyles.None, out result);

        }
        
        internal static bool IsObject(dynamic model)
        {
            if (model == null) return false;
            string validObjId = "" + model.Id;
            if (model != null && (ObjectId.TryParse(validObjId, out _) && model.Id != null && !model.Id.Equals("") && model.Name != null && !model.Name.Equals("")))
            {
                return true;
            }
            return false;
        }
        
        internal static bool IsCommonVaild(CommonModelShort model)
        {
            if (model == null) return false ; 
            string validObjId = "" + model.Id;
            var f = ObjectId.TryParse(validObjId, out _);
            if (model != null && (ObjectId.TryParse(validObjId, out _) && model.Id != null && !model.Id.Equals("") && model.Name != null && !model.Name.Equals("") && model.Code != null && !model.Code.Equals("")))
            {
                return true;
            }              
            return false;
        }
    
        internal static bool IsListConmonValid(List<CommonModelShort> models)
        {
            if (models == null) return true;  
            foreach (var model in models)
            {
                string validObjId = "" + model.Id;
                if (model.Id == null || model.Id.Equals("") || !ObjectId.TryParse(validObjId, out _) ||
                    model.Name == null || model.Name.Equals("") ||
                    model.Code == null || model.Code.Equals(""))
                {
                    return false;
                }
            }
            return true; 
        }

        internal static bool checkFormatTimeString(string val)
        {
            try
            {
                DateTime dt = DateTime.ParseExact(val, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                string tempdate = dt.ToString("HH:mm");
                if (tempdate == val)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION).WithMessage(ex.Message);
            }
        }
    }
}