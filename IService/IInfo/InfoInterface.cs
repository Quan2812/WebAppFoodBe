using FOLYFOOD.Dto;
using FOLYFOOD.Dto.InfoDto;
using FOLYFOOD.Entitys;

namespace FOLYFOOD.IService.IInfo
{
    public interface InfoInterface
    {
       public Task<RetunObject<Info>> addInfo(InfoRequets info);
       public Task<RetunObject<Info>> showInfo(int info);
       public Task<RetunObject<Info>> getInfo();
       public Task<RetunObject<Info>> deleteInfo(int infoId);
       public Task<IQueryable<Info>> getAllInfo();
    }
}
