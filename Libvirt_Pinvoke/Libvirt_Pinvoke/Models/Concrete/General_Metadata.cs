﻿using Libvirt.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libvirt.Models.Concrete
{
    public class General_Metadata : ITo_XML, IValidation
    {
        public General_Metadata()
        {

        }
        public string name { get; set; }
        private string _uuid = "";
        public string uuid { get { return _uuid; } }//uuid is ommited for xml generation because it is only a read operation, it cannot be set
        public string title { get; set; }
        public string description { get; set; }
        public string To_XML()
        {
            var ret = "";
            ret += "<name>" + name + "</name>";
            ret += "<title>" + title + "</title>";
            ret += "<description>" + description + "</description>";
            return ret;
        }
        public void Validate(IValdiator v)
        {
            if (string.IsNullOrWhiteSpace(name)) v.AddError("General_Metadata.name", "Name cannot be empty!");
            else
            {
                foreach (var item in name)
                {
                    if (!Char.IsLetter(item) && item != '_')
                    {
                        v.AddError("General_Metadata.name", "Name can only contain letters or underscores!");
                        break;
                    }
                }
            }
        }
    }
}
