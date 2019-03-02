using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using DAL.Amlo.Master;
using System.Data;
using DTO.Amlo.Master;
using DTO.Amlo.Importing;

namespace BAL.Amlo.Master
{
    public class M_CustomerBAL : BALBase
    {
        bool isCan = false;
        M_CustomerDAL dao = null;
        DataTable dt = null;
        DataRow dr = null;
        public M_CustomerBAL()
        {

            dao = new M_CustomerDAL();
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

        public bool Action(List<M_CustomerDTO> objectList)
        {



            try
            {
                // dao.Add(objectList);
            }
            catch (Exception ex)
            {

                Log("M_CustomerBAL.Action", "High", ex.ToString());
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

        public List<M_CustomerDTO> FindByObjList(object dto)
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

                Log("M_CustomerBAL.Add", "High", ex.ToString());
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

                Log("M_CustomerBAL.Update", "High", ex.ToString());
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

                Log("M_CustomerBAL.Delete", "High", ex.ToString());
            }
            finally
            { }


            return isCan;

        }

        public DataSet FindAccountAndAddress(string CustomerOID)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerOID");
            dr = dt.NewRow();
            dr["CustomerOID"] = CustomerOID;
            dt.Rows.Add(dr);
            return dao.FindAccountAndAddress(dt);
        }
    }
}
