﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagerLibrary.Models
{

    public static class EnumExtensionMethods
    {
        public static string GetDescription(this Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return ((System.ComponentModel.DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }
            return GenericEnum.ToString();
        }

    }


    public class FriendlyEnumMethods
    {
        public static string GetFriendlyCaseStatusEnums()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (CaseStatus caseStatus in Enum.GetValues(typeof(CaseStatus)))
            {
                stringBuilder.Append(caseStatus.GetDescription() + "|");
            }
            return stringBuilder.ToString();
        }
    }
}
