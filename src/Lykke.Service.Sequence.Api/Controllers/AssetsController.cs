using Lykke.Service.BlockchainApi.Contract;
using Lykke.Service.BlockchainApi.Contract.Assets;
using Lykke.Service.Sequence.Api.Core.Domain;
using Lykke.Service.Sequence.Api.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lykke.Service.Sequence.Api.Controllers
{
    [Route("api/assets")]
    public class AssetsController : Controller
    {
        [HttpGet]
        public PaginationResponse<AssetResponse> Get([Required, FromQuery] int take, [FromQuery] string continuation)
        {
            var assets = new AssetResponse[] { Asset.Sequence.ToAssetResponse() };

            return PaginationResponse.From("", assets);
        }

        [HttpGet("{assetId}")]
        [ProducesResponseType(typeof(AssetResponse), StatusCodes.Status200OK)]
        public IActionResult GetAsset([Required] string assetId)
        {
            if(Asset.Sequence.Id != assetId)
            {
                return NotFound();
            }

            return Ok(Asset.Sequence.ToAssetResponse());
        }
    }
}
