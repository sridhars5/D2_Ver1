using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
  public  class managed_arrays
    {
        public byte[] createManagedArr(byte[] arr, int arr_size)
        {
            byte[] managedArray = new byte[arr_size];
            for (int i = 0; i < arr_size; i++)
            {

                managedArray[i] = (byte)(arr[i]);

               
               // managedArray[i] =(byte)(arr.Length);
            }
            return managedArray;
        }

        public void copyToManagedArr(System.Byte[] unmanaged_arr, ref System.Byte[] managed_arr, int arr_size)
        {
            for (int i = 0; i < arr_size; i++)
            {
                managed_arr[i] = unmanaged_arr[i];
            }
        }

        // Float array management
        //C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on the parameter 'arr', so pointers on this parameter are left unchanged:
        public float[] createManagedArr(float[] arr, int arr_size)
        {


            float[] managedArray = new float[arr_size];
           
            for (int i = 0; i < arr_size; ++i)
            {
               managedArray[i] =(float)(arr[i]);

             
            }
            return managedArray;
        }

        public void copyToManagedArr(float[] unmanaged_arr, ref float[] managed_arr, int arr_size)
        {
            for (int i = 0; i < arr_size; i++)
            {
                managed_arr[i] = unmanaged_arr[i];
            }
        }








    }
}
