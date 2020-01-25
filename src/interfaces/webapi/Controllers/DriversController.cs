using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WappaMobile.ChallengeDev.GoogleMaps;
using WappaMobile.ChallengeDev.Models;
using WappaMobile.ChallengeDev.Persistence;

namespace WappaMobile.ChallengeDev.Client.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        readonly GeoCodeServices _googleMaps = new GeoCodeServices();

        [HttpGet]
        public ActionResult<IEnumerable<Driver>> Get([FromQuery]string orderby = "")
        {
            try
            {
                var model = Database.Drivers.GetAll();

                if (orderby.ToLower().Equals("fistname"))
                    return Ok(model.OrderBy(x => x.Name.FirstName));

                if (orderby.ToLower().Equals("lastname"))
                    return Ok(model.OrderBy(x => x.Name.LastName));

                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Driver> Get(Guid id)
        {
            try
            {
                var driver = Database.Drivers.Get(id);
                return Ok(driver);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Driver driver)
        {
            if (!driver.IsValid)
                return BadRequest("It is not a valid driver.");

            try
            {
                var coord = await _googleMaps.SearchAsync(driver.Address);
                driver.Address.Coordinate = coord;
                Database.Drivers.Add(driver);

                return Ok(driver.Id);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Driver value)
        {
            value.Id = id;

            try
            {
                Database.Drivers.Save(value);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                Database.Drivers.Remove(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
