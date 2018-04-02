using System;

namespace NugetDemo
{
    public interface IModelMapper<TDto, TEntity>
    {
        TDto DtoFrom(TEntity domainEntity);


        TEntity EntityFrom(TDto dto);
    }
}
