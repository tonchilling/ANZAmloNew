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

namespace BAL.Amlo.Importing
{
    public class ImportTempBAL : BALBase
    {
        bool isCan = false;
        SourceFile_MappingHeaderDAL dao = null;
        DataTable dt = null;
        DataRow dr = null;
        public ImportTempBAL()
        {

            dao = new SourceFile_MappingHeaderDAL();
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

        public bool Action(List<SourceFile_MappingHeaderDto> objectList)
        {



            try
            {
                // dao.Add(objectList);
            }
            catch (Exception ex)
            {

                Log("ImportTempBAL.Action", "High", ex.ToString());
            }
            finally
            { }
            return isCan;
        }


        public bool Import(List<ImportDTO>  objectList)
        {



            try
            {
                dao.ImportAll(objectList);
            }
            catch (Exception ex)
            {

                Log("ImportTempBAL.Import", "High", ex.ToString());
            }
            finally
            { }
            return isCan;
        }
        public bool Import(List<ImportDTO> objectList, DataTable importHeaderDT)
        {



            try
            {
                dao.ImportAll(objectList, importHeaderDT);
            }
            catch (Exception ex)
            {

                Log("ImportTempBAL.Import", "High", ex.ToString());
            }
            finally
            { }
            return isCan;
        }

        public bool Import(List<ImportDTO> objectList
                            ,DataTable importHeaderDT
                           , DataTable importDetailDT)
        {



            try
            {
                dao.ImportAll(objectList, importHeaderDT, importDetailDT);
            }
            catch (Exception ex)
            {

                Log("ImportTempBAL.Import", "High", ex.ToString());
            }
            finally
            { }
            return isCan;
        }


        public override DataTable FindByColumn(object dto)
        {
            dt = SourceFile_MappingHeaderDto.Data();
            dr = dt.NewRow();
            dr["Name"] = "";
            return dao.FindByColumn(dt);
        }

        public DataSet FindHeaderAndDetailPK(object dto)
        {
            dt = SourceFile_MappingHeaderDto.Data();
            dr = dt.NewRow();
            dr["HID"] = "1";
            dt.Rows.Add(dr);
            return dao.FindHeaderAndDetailPK(dt);
        }



        /// <summary>
        /// active =1 /0 if active is empty then show all
        /// </summary>
        /// <param name="name"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        public DataTable FindByColumn(string name, string active)
        {
            dt = SourceFile_MappingHeaderDto.Data();
            dr = dt.NewRow();
            dr["Name"] = name;
            dr["ROW_STATE"] = active;
            dt.Rows.Add(dr);
            return dao.FindByColumn(dt);
        }

        protected override bool Add()
        {

            try
            {
                isCan = dao.Add(dt);
            }
            catch (Exception ex)
            {

                Log("PER_MENU_PERMISSIONBL.Add", "High", ex.ToString());
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

                Log("PER_MENU_PERMISSIONBL.Update", "High", ex.ToString());
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

                Log("PER_MENU_PERMISSIONBL.Delete", "High", ex.ToString());
            }
            finally
            { }


            return isCan;

        }
    }
}
