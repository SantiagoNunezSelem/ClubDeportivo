using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Datos {

        public static bool Guardar(object o) {
            bool ok = false;
            try {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream miArchivo = new FileStream("Adminstradora.dat", FileMode.Create);
                bf.Serialize(miArchivo, o);
                miArchivo.Close();
                ok = true;
            } catch (Exception ex) {
                ok = false;
            }
            return ok;
        }

        public static object Recuperar() {
            FileStream miArchivo = null;
            try {
                BinaryFormatter bf = new BinaryFormatter();
                miArchivo = new FileStream("Adminstradora.dat", FileMode.Open);
                object o = bf.Deserialize(miArchivo);
                miArchivo.Close();
                File.Delete("Adminstradora.dat");
                return o;

            } catch (System.IO.IOException ex) {
                return null;
            } catch (System.Runtime.Serialization.SerializationException ex) {
                miArchivo.Close();
                return null;
            }

        }
    }
}
