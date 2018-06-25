using Lykke.Service.BlockchainApi.Contract.Addresses;
using Lykke.Service.Sequence.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Lykke.Service.Sequence.Api.Controllers
{
    [Route("api/addresses")]
    public class AddressesController : Controller
    {
        private readonly ISequenceService _sequenceService;

        public AddressesController(ISequenceService sequenceService)
        {
            _sequenceService = sequenceService;
        }

        [HttpGet("{address}/validity")]
        [ProducesResponseType(typeof(AddressValidationResponse), (int)HttpStatusCode.OK)]
        public IActionResult GetAddressValidity([Required] string address)
        {
            return Ok(new AddressValidationResponse()
            {
                IsValid = _sequenceService.GetBitcoinAddress(address) != null
            });
        }
    }
}
