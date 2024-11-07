using AutoMapper;
using Bussiness.Services;
using Entities.DTOS.Packets;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class PacketsController : ControllerBase
    {
        private readonly IPacketService _service;
        private IMapper _mapper;
        public PacketsController(IPacketService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet("ActivePackets")]
        public async Task<IActionResult> ActivePacketList()
        {

            var packets = _mapper.Map<IEnumerable<PacketListDTO>>(await _service.ActivePackets());
            return Ok(packets); 
        }
        [HttpGet("DeactivePackets")]
        public async Task<IActionResult> DeactivePacketList()
        {

            var packets = _mapper.Map<IEnumerable<PacketListDTO>>(await _service.DeactivePackets());
            return Ok(packets);
        }
    }
}
