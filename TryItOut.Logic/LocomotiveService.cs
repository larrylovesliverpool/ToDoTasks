using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.CommonInterfaces;
using TryItOut.Service.DTOs;
using TryItOut.Service.Interfaces;

namespace TryItOut.Logic
{
    public class LocomotiveService : ILocomotiveService
    {
        private ILocomotiveRepository repo = null;

        public LocomotiveService(ILocomotiveRepository repo) {

            this.repo = repo;
        }

        public void Locomotives()
        {
            LocomotiveDTO locoDTO = new LocomotiveDTO();

            var data = repo.Read();
        }

        public LocomotiveDTO Read(int id)
        {
            LocomotiveDTO locoDTO = new LocomotiveDTO();

            var data = repo.Read(id);

            return locoDTO;
        }

        public LocomotivesDTO read()
        {
            LocomotivesDTO dto = new LocomotivesDTO();

            var data = repo.Read();

            /* Mapper domain to vm */

            foreach(var loco in data)
            {
                dto.NumberOf++;

                dto.listOfLocomotives.Add(new LocomotiveDTO() {
                    LocoId = loco.LocoId,
                    Description = loco.Description,
                    Name = loco.Name,
                    DCCValue = loco.DCCValue,
                    Decoder = loco.Decoder,
                    MadeBy = loco.MadeBy,
                    Classification = loco.Classification,
                    YearPurchased = loco.YearPurchased
                });
            }

            if( dto.NumberOf > 0 ) 
            {
                dto.hasLocomotives = true;
            }

            return dto;
        }

        public LocomotiveDetailsDTO ReadDetails(int id)
        {
            LocomotiveDetailsDTO locoDTO = new LocomotiveDetailsDTO();

            var data = repo.ReadFullDetails(id);

            locoDTO.LocoId = data.LocoId;
            locoDTO.Name = data.Name;
            locoDTO.Manufacturer = data.Manufacturer;
            locoDTO.Decoder = data.Decoder;
            locoDTO.DecoderDetails = data.DecoderDetails;
            locoDTO.DCCValue = data.DCCValue;
            locoDTO.Description = data.Description;
            locoDTO.YearPurchased = data.YearPurchased;
            locoDTO.Classification = data.Classification;
            locoDTO.ClassificationDetails = data.ClassificationDetails;
            locoDTO.Power = data.Power;

            return locoDTO;
        }

        public LocomotivesDetailsDTO ReadDetails()
        {
            LocomotivesDetailsDTO dto = new LocomotivesDetailsDTO();

            /* Map domain model to data transfer object */

            foreach (var loco in repo.ReadFullDetails())
            {
                dto.listOfLocomotives.Add(new LocomotiveDetailsDTO()
                {
                    LocoId = loco.LocoId,
                    Name = loco.Name,
                    MadeBy = loco.MadeBy,
                    Manufacturer = loco.Manufacturer,
                    Decoder = loco.Decoder,
                    DecoderDetails = loco.DecoderDetails,
                    DCCValue = loco.DCCValue,
                    Description = loco.Description,
                    YearPurchased = loco.YearPurchased,
                    Classification = loco.Classification,
                    ClassificationDetails = loco.ClassificationDetails,
                    Power = loco.Power
                });
            }

            if (dto.listOfLocomotives.Count > 0)
            {
                dto.HasLocomotives = true;
            }

            return dto;
        }

        public void Save() { }

        public void Delete() { }

        public void Update() { }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
