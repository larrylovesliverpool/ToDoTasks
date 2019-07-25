using System;
using TryItOut.CommonInterfaces;
using TryItOut.Service.DTOs;
using TryItOut.Service.Interfaces;

namespace TryItOut.Logic
{
    public class LocomotiveTypeService : ILocomotiveTypeService
    {
        ILocomotiveTypesCRUD repo = null;

        public LocomotiveTypeService (ILocomotiveTypesCRUD repo)
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

        public LocomotiveClassificationDTO Read(int id)
        {
            LocomotiveClassificationDTO dto = new LocomotiveClassificationDTO();
            var data = Read().listOfClassifications.Find( x => x.ClassificationId == id);

            /* map to dto */

            dto.ClassificationId = data.ClassificationId;
            dto.Classification = data.Classification;
            dto.Power = data.Power;
            dto.Comments = data.Comments;

            return dto;
        }

        public LocomotiveClassificationsDTO Read()
        {
            LocomotiveClassificationsDTO dto = new LocomotiveClassificationsDTO();
            var locoClassifications = repo.Read();

            /* transfer from domain model to dto */

            if (locoClassifications.Count > 0)
            {
                foreach (var cls in locoClassifications)
                {
                    dto.listOfClassifications.Add(new LocomotiveClassificationDTO()
                    {
                        ClassificationId = cls.ClassificationId,
                        Power = cls.Power,
                        Classification = cls.Classification,
                        Comments = cls.Comments
                    });
                }

                dto.hasTypes = true;
                dto.count = dto.listOfClassifications.Count;
            }
            else
            {
                dto.hasTypes = false;
            }

            return dto;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

    }
}
