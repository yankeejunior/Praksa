using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalPraksa.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalPraksa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceTypePropertyController : ControllerBase
    {
        private readonly DataContext _context;

        public DeviceTypePropertyController(DataContext context)
        {
            _context = context;

            if (_context.DeviceTypeProperties.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.DeviceTypeProperties.Add(new DeviceTypeProperty { Name = "Device Type Property" });
                _context.SaveChanges();
            }
        }

        // GET: api/devicetype
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeviceTypeProperty>>> GetDeviceTypeProperties()
        {
            return await _context.DeviceTypeProperties.ToListAsync();
        }

        // GET: api/devicetype/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeviceTypeProperty>> GetDeviceTypeProperty(long id)
        {
            var deviceTypeProperty = await _context.DeviceTypeProperties.FindAsync(id);

            if (deviceTypeProperty == null)
            {
                return NotFound();
            }

            return deviceTypeProperty;
        }

        // POST: api/device
        [HttpPost]
        public async Task<ActionResult<DeviceTypeProperty>> PostDeviceTypeProperty(DeviceTypeProperty deviceTypeProperty)
        {
            _context.DeviceTypeProperties.Add(deviceTypeProperty);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeviceTypeProperty", new { id = deviceTypeProperty.Id }, deviceTypeProperty);
        }


        // PUT: api/device/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeviceTypeProperty(long id, DeviceTypeProperty deviceTypeProperty)
        {
            if (id != deviceTypeProperty.Id)
            {
                return BadRequest();
            }

            _context.Entry(deviceTypeProperty).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Todo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeviceTypeProperty>> DeleteDeviceTypeProperty(long id)
        {
            var deviceTypeProperty = await _context.DeviceTypeProperties.FindAsync(id);
            if (deviceTypeProperty == null)
            {
                return NotFound();
            }

            _context.DeviceTypeProperties.Remove(deviceTypeProperty);
            await _context.SaveChangesAsync();

            return deviceTypeProperty;
        }
    }
}
