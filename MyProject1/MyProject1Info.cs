﻿using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace MyProject1
{
    public class MyProject1Info : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "MyProject1";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("3043c04d-11fb-49b4-a6eb-18ecad7a2585");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
