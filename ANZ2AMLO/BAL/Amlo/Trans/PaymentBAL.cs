using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using DAL.Amlo.Trans;
using System.Data;
using DTO.Amlo.Trans;
using DTO.Amlo.Importing;

namespace BAL.Amlo.Master
{
    public class PaymentBAL : BALBase
    {
        bool isCan = false;
        PaymentDAL dao = null;
        DataTable dt = null;
        DataRow dr = null;
        public PaymentBAL()
        {

            dao = new PaymentDAL();
        }

        public override bool Action()
        {
            //switch (myPage.Request.Form["status"])
            //{
            //    case "add": isCan = Add(); break;
            //    case "update": isCan = Update(); break;
            //    case "delete": isCan = Delete(); break;

            //}
            return isCan;
        }

        public override DataTable FindByAll()
        {

            return dao.FindByAll();
        }

        public bool Action(List<PaymentDto> objectList)
        {



            try
            {
                // dao.Add(objectList);
            }
            catch (Exception ex)
            {

                Log("PaymentBAL.Action", "High", ex.ToString());
            }
            finally
            { }
            return isCan;
        }


      


        public override DataTable FindByColumn(object dto)
        {
            //dt = SourceFile_MappingHeaderDto.Data();
            //dr = dt.NewRow();
            //dr["Name"] = "";
            //return dao.FindByColumn(dt);
            return null;
        }

        public List<TransactionANZ> FindByObjList(object dto)
        {
            return dao.FindByObjList(dto);
            //dt = SourceFile_MappingHeaderDto.Data();
            //dr = dt.NewRow();
            //dr["HID"] = "1";
            //dt.Rows.Add(dr);
            //return dao.FindHeaderAndDetailPK(dt);
        }



        /// <summary>
        /// active =1 /0 if active is empty then show all
        /// </summary>
        /// <param name="name"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        public DataTable FindByColumn(string name, string active)
        {
            /* dt = SourceFile_MappingHeaderDto.Data();
             dr = dt.NewRow();
             dr["Name"] = name;
             dr["ROW_STATE"] = active;
             dt.Rows.Add(dr);
             return dao.FindByColumn(dt);*/
            return null;
        }

        protected override bool Add()
        {

            try
            {
                isCan = dao.Add(dt);
            }
            catch (Exception ex)
            {

                Log("PaymentBAL.Add", "High", ex.ToString());
            }
            finally
            { }
            return isCan;


        }

        protected override bool Update()
        {

            try
            {
                isCan = dao.Update(dt);
            }
            catch (Exception ex)
            {

                Log("PaymentBAL.Update", "High", ex.ToString());
            }
            finally
            { }

            return isCan;

        }

        protected override bool Delete()
        {

            try
            {
                isCan = dao.Delete(dt);
            }
            catch (Exception ex)
            {

                Log("PaymentBAL.Delete", "High", ex.ToString());
            }
            finally
            { }


            return isCan;

        }

       
    }
}
