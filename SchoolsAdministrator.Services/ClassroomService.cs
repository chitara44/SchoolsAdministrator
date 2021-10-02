using SchoolsAdministrator.Core.Entities;
using SchoolsAdministrator.Core.Interfaces;
using SchoolsAdministrator.Core.Interfaces.Services;
using SchoolsAdministrator.Services.Validators;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolsAdministrator.Services
{
    public class ClassroomService : IClassroomService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ClassroomService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Classroom> CreateClassroom(Classroom newClassroom)
        {
            ClassroomValidator validator = new();

            var validationResult = await validator.ValidateAsync(newClassroom);
            if (validationResult.IsValid)
            {
                await _unitOfWork.ClassroomRepository.AddAsync(newClassroom);
                await _unitOfWork.CommitAsync();
            }
            else
            {
                throw new ArgumentException(validationResult.Errors.ToString());
            }

            return newClassroom;
        }

        public async Task DeleteClassroom(int classroomId)
        {
            Classroom classroom = await _unitOfWork.ClassroomRepository.GetByIdAsync(classroomId);
            _unitOfWork.ClassroomRepository.Remove(classroom);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Classroom>> GetAll()
        {
            return await _unitOfWork.ClassroomRepository.GetAllAsync();
        }

        public async Task<Classroom> GetClassroomById(int id)
        {
            return await _unitOfWork.ClassroomRepository.GetByIdAsync(id);
        }

        public async Task<Classroom> UpdateClassroom(int classroomToBeUpdatedId, Classroom newClassroomValues)
        {
            ClassroomValidator classroomValidator = new();

            var validationResult = await classroomValidator.ValidateAsync(newClassroomValues);
            if (!validationResult.IsValid)
                throw new ArgumentException(validationResult.Errors.ToString());

            Classroom classroomToBeUpdated = await _unitOfWork.ClassroomRepository.GetByIdAsync(classroomToBeUpdatedId);

            if (classroomToBeUpdated == null)
                throw new ArgumentException("Invalid classroom ID while updating");

            classroomToBeUpdated.Name = newClassroomValues.Name;
            classroomToBeUpdated.Capacity = newClassroomValues.Capacity;
            classroomToBeUpdated.SchoolId = newClassroomValues.SchoolId;

            await _unitOfWork.CommitAsync();

            return await _unitOfWork.ClassroomRepository.GetByIdAsync(classroomToBeUpdatedId);
        }
    }
}