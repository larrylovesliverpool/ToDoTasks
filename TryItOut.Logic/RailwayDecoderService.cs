using System;
using TryItOut.CommonInterfaces;
using TryItOut.Service.DTOs;
using TryItOut.Service.Interfaces;

namespace TryItOut.Logic
{
    public class RailwayDecoderService : IRailwayDecoderService<RailwayDecoderDTO>
    {
        IRailwayDecoderCRUD repo = null;

        public RailwayDecoderService(IRailwayDecoderCRUD repo)
        {
            this.repo = repo;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        RailwayDecoderDTO IRailwayDecoderService<RailwayDecoderDTO>.Read(int id)
        {
            RailwayDecoderDTO dto = new RailwayDecoderDTO();
            var data = repo.Read(id);

            /* map to dto */

            dto.DecoderId = data.DecoderId;
            dto.Manufacturer = data.Manufacturer;
            dto.StayALive = data.StayALive;
            dto.Description = data.Description;

            return dto;
        }

        RailwayDTO<RailwayDecoderDTO> IRailwayDecoderService<RailwayDecoderDTO>.Read()
        {
            RailwayDTO<RailwayDecoderDTO> dto = new RailwayDTO<RailwayDecoderDTO>();
            var decoders = repo.Read();

            /* transfer from domain model to dto */

            if (decoders.Count > 0)
            {
                foreach (var decoder in decoders)
                {
                    dto.ListOf.Add(new RailwayDecoderDTO()
                    {
                        DecoderId = decoder.DecoderId,
                        Manufacturer = decoder.Manufacturer,
                        StayALive = decoder.StayALive,
                        Description = decoder.Description,
                        Type = decoder.Type
                    });
                }

                dto.HasData = true;
            }
            else
            {
                dto.HasData = false;
            }

            return dto;
        }
    }
}
