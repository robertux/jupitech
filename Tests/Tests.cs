/*
 * 
/////////////////IrrJ\\\\\\\\\\\\\\\\\\
Archivo de código fuente desarrollado
por IrrJ en SharpDevelop 1.2
 * Date: 01/01/2001
 * Time: 6:26
/////////////////IrrJ\\\\\\\\\\\\\\\\\\
 * 
*/
using System;
using System.Collections.Generic;
using Jupitech.Manejadores;
using Jupitech.Entidades;
using NUnit.Framework;
using CDS.PgSql;
using System.Data;
using Npgsql;

namespace Jupitech
{
	namespace Tests
	{
		[TestFixture]
		public class Tests
		{
//			CustomPgSqlDataSource ds;
			
//			[SetUp]
//			public void Inicio()
//			{
//				ds = MnjDatos.GetDS();
//				ds.CargarDS();
//			}
			
//			[TearDown]
//			public void Fin()
//			{
//				ds.ActualizarBD();
//			}
			
            //[Test]
            //public void TestAgregarDatos()
            //{
				
            //    Assert.IsNotNull(ds);				
            //    Assert.IsNotNull(ds.DS);
            //    Assert.AreEqual(30,ds.DS.Tables.Count);
            //    Usuario u = new Usuario("NombreUsuario4", "ClaveUsuario3", 2);
            //    Assert.AreEqual(3,ds.DS.Tables["usuarios"].Rows.Count);
            //    Assert.IsTrue(ManejadorDatos.Agregar("usuarios",ds.DS,u.GetObjArray()));
            //    Assert.AreEqual(4,ds.DS.Tables["usuarios"].Rows.Count);
            //}
			
            //[Test]
            //public void TestEliminar()
            //{
            //    //Assert.AreEqual(3,ds.DS.Tables["usuarios"].Rows.Count);
            //    //Assert.IsTrue(ManejadorEntidades.Eliminar("usuarios",ds.DS,1));
            //    //Assert.AreEqual(2,ds.DS.Tables["usuarios"].Rows.Count);
            //    //ds.ActualizarBD();
            //}
			
            //[Test]
            //public void TestModificar()
            //{
            //    Assert.IsNotNull(ds);				
            //    Assert.IsNotNull(ds.DS);
            //    Assert.AreEqual(30,ds.DS.Tables.Count);		
            //    Assert.AreEqual(4,ds.DS.Tables["usuarios"].Rows.Count);
            //    Usuario u = new Usuario("","",0);
            //    u.Codigo = (int)ds.DS.Tables["usuarios"].Rows[0]["codigo"];
            //    u.Nombre = (string)ds.DS.Tables["usuarios"].Rows[0]["nombre"];
            //    u.Clave = (string)ds.DS.Tables["usuarios"].Rows[0]["clave"];
            //    Assert.AreEqual(u.Nombre, "NombreUsuario1");
            //    u.Nombre = "NombreModif1";
            //    Console.WriteLine("Codigo: " + u.Codigo);
            //    Assert.IsTrue(ManejadorEntidades.Modificar("usuarios",ds.DS,u.GetObjArray(),u.Codigo));
            //    ds.ActualizarBD();
            //}
            
            [Test]
            public void TestAddUsuario()
            {
            	Usuario u = new Usuario("NewUser1","NewPwd1",0);
            	CustomPgSqlDataSource ds = Manejador.GetDS();
            	MnjUsuarios.AddUsuario(u,ds.DS);
            	ds.ActualizarBD();
            }
            
            [Test]
            public void TestEditUsuario()
            {
            	CustomPgSqlDataSource ds = Manejador.GetDS();
            	Usuario u = MnjUsuarios.GetUsuario(6,ds.DS);
            	u.Nombre = "UpdtUser1";
            	MnjUsuarios.EditUsuario(u, ds.DS);
            	ds.ActualizarBD();
            }
            
            [Test]
            public void TestDelUsuario()
            {
            	CustomPgSqlDataSource ds = Manejador.GetDS();
            	Usuario u = MnjUsuarios.GetUsuario(6,ds.DS);
            	MnjUsuarios.DelUsuario(u,ds.DS, new NpgsqlConnection(ds.CadenaConexion));
            	ds.ActualizarBD();
            }
            
		}
	}
}
