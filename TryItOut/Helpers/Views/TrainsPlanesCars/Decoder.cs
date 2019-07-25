

using TryItOut.Logic;
using TryItOut.Service.DTOs;
using TryItOut.Service.Interfaces;
using TryItOut.ViewModels;

namespace TryItOut.Helpers.Views
{
    public class DecoderHelper : IDecoderhelper
    {
        readonly IRailwayDecoderService<RailwayDecoderDTO> decoderService = null;

        public DecoderHelper(IRailwayDecoderService<RailwayDecoderDTO> service)
        {
            decoderService = service;
        }

        public RailwayViewModel<RailwayDecoder> CreateviewModel()
        {
            RailwayViewModel<RailwayDecoder> vm = new RailwayViewModel<RailwayDecoder>();

            var data = decoderService.Read();

            foreach( var item in data.ListOf)
            {
                vm.HasData = true;

                vm.ListOf.Add(new RailwayDecoder() {

                     DecoderId = item.DecoderId,
                     Description = item.Description,
                     Manufacturer = item.Manufacturer,
                     StayALive = item.StayALive,
                     Type = item.Type
                });

            }

            return vm;
        }

    }
}

