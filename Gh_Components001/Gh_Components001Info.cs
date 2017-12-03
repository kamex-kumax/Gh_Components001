using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace Gh_Components001
{
    public class Gh_Components001Info : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "GhComponents001";
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
                return new Guid("7015599f-0e75-4267-8c86-a871e1bf89df");
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
