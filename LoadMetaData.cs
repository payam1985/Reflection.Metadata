﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaData
{
    public class LoadMetaData
    {
        private Type type;

        public LoadMetaData(Type type)
        {
            this.type = type;
        }

        public string LoadProperties()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("-------------------------------------");
            builder.AppendLine("Generic Type Information");
            builder.AppendLine("--------------------------------------");
            builder.AppendLine($"Name : {type.Name}");
            builder.AppendLine($"Namespace : {type.Namespace}");
            builder.AppendLine($"Asse : {type.Namespace}");
            if(type.BaseType != null)
                builder.AppendLine($"Base type : {type.BaseType}");
            builder.AppendLine($"Is Public : {type.IsPublic}");
            builder.AppendLine($"Is Class : {type.IsClass}");
            builder.AppendLine($"Is Interface : {type.IsInterface}");
            builder.AppendLine($"Is Generic : {type.IsGenericType}");
            builder.AppendLine("----- Get Generic Args");
            foreach (var arg in type.GetGenericArguments())
            {
                builder.AppendLine($"       <{arg.Name}>");
            }
            builder.AppendLine("----- Implemented Interfaces");
            foreach (var inter in type.GetInterfaces())
            {
                builder.AppendLine($"        implemeted {inter.Name}")
            }

            return builder.ToString();
        }
    }

    public class LoadMetaData<T> : LoadMetaData
    {
        public LoadMetaData() : base(typeof(T))
        {
        }
    }
}
