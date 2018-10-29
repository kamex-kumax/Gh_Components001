using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;
using Grasshopper;

namespace RecordData
{
    public class RecordDataComponent : GH_Component
    {
        /// <summary>
        /// Each implementation of GH_Component must provide a public 
        /// constructor without any arguments.
        /// Category represents the Tab in which the component will appear, 
        /// Subcategory the panel. If you use non-existing tab or panel names, 
        /// new tabs/panels will automatically be created.
        /// </summary>
        public RecordDataComponent()
          : base("RecordData", "Rec",
              "This component just record some data you want to record temporary. Only that. It's developed by Archi-Informatics inc.",
              "Archi-Informatics Inc.", "Util")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            // Use the pManager object to register your input parameters.
            // You can often supply default values when creating parameters.
            // All parameters must have the correct access type. If you want 
            // to import lists or trees of values, modify the ParamAccess flag.
            pManager.AddGenericParameter("Input Data", "I", "Please input data you wanted to record temporary", GH_ParamAccess.tree);
            pManager.AddBooleanParameter("Record Botton", "R", "Please connect a botton component here. When you push a botton, input data will be record.", GH_ParamAccess.tree);
            pManager.AddBooleanParameter("Discard Botton", "D", "Please connect a botton component here. (optional) When you push a botton, recorded data will be discard.", GH_ParamAccess.tree);

            // If you want to change properties of certain parameters, 
            // you can use the pManager instance to access them by index:
            pManager[2].Optional = false;
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            // Use the pManager object to register your output parameters.
            // Output parameters do not have default values, but they too must have the correct access type.
            pManager.AddGenericParameter("Output Data", "O", "if this component have some recorded data, output these data.", GH_ParamAccess.tree);

            // Sometimes you want to hide a specific parameter from the Rhino preview.
            // You can use the HideParameter() method as a quick way:
            //pManager.HideParameter(0);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object can be used to retrieve data from input parameters and 
        /// to store data in output parameters.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            DataTree<object> input;
            bool rec;
            bool dis;
            DataTree<object> output;

            if (!DA.GetData(0, ref input)) return;
            if (!DA.GetData(1, ref rec)) return;
            if (!DA.GetData(2, ref dis)) return;

            if (rec) _StoredObject = input;
            if (dis) _StoredObject = null;

            DA.SetData(0, _StoredObject);
        }

        /// <summary>
        /// The Exposure property controls where in the panel a component icon 
        /// will appear. There are seven possible locations (primary to septenary), 
        /// each of which can be combined with the GH_Exposure.obscure flag, which 
        /// ensures the component will only be visible on panel dropdowns.
        /// </summary>
        public override GH_Exposure Exposure
        {
            get { return GH_Exposure.primary; }
        }

        /// <summary>
        /// Provides an Icon for every component that will be visible in the User Interface.
        /// Icons need to be 24x24 pixels.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                // You can add image files to your project resources and access them like this:
                //return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Each component must have a unique Guid to identify it. 
        /// It is vital this Guid doesn't change otherwise old ghx files 
        /// that use the old ID will partially fail during loading.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("a3cabdaa-6312-4607-9f01-7f08081bf12b"); }
        }
    }
}
