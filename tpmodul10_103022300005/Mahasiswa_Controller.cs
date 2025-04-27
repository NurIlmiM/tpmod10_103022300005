using Microsoft.AspNetCore.Mvc;
using tpmodul10_103022300005.Models;
using System.Collections.Generic;
namespace tpmodul10_103022300005.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Mahasiswa_Controller : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Nur Ilmi Mufidah", Nim = "103022300005" },
            new Mahasiswa { Nama = "Benaya Giuseppe Linggaputra Sinulingga", Nim = " 103022330122" },
            new Mahasiswa { Nama = "Yudha Harwanto Putra", Nim = "103022300010" },
            new Mahasiswa { Nama = "Sidqi Athallah Ar-Rasyid", Nim = "103022300108" },
            new Mahasiswa { Nama = "Nicholas Putra Irawan", Nim = "103022330091" },
            new Mahasiswa { Nama = "Rizqie Ahmad Zakaria Hende", Nim = "103023300118" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAll()
        {
            return Ok(mahasiswaList);
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Index tidak ditemukan.");

            return Ok(mahasiswaList[index]);
        }

        [HttpPost]
        public ActionResult AddMahasiswa([FromBody] Mahasiswa newMahasiswa)
        {
            mahasiswaList.Add(newMahasiswa);
            return Ok("Mahasiswa berhasil ditambahkan.");
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Index tidak ditemukan.");

            mahasiswaList.RemoveAt(index);
            return Ok("Mahasiswa berhasil dihapus.");
        }
    }
}
