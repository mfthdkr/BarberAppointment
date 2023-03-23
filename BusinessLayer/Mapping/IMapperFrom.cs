using AutoMapper;

namespace BusinessLayer.Mapping
{
    public interface IMapperFrom<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
