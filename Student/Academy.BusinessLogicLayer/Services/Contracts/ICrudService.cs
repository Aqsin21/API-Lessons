namespace Academy.BusinessLogicLayer.Services.Contracts
{
    public interface ICrudService<TDto ,TCreateDto ,TUpdateDto ,TEntity>
    {
        Task<List<TDto>> GetAllAsync();
        Task<TDto> GetByIdAsync(int id);
        Task<TDto> AddAsync(TCreateDto tCreateDto);
        Task<TDto> UpdateAsync(TUpdateDto  tUpdateDto);
        Task<TDto> DeleteAsync(int id);

    }
}
