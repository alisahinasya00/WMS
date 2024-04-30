using AutoMapper;
using Infrastructure.Model;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Business.CustomExceptions;
using WMS.Business.Interfaces;
using WMS.DataAccess.Interfaces;
using WMS.Model.Dtos.Blok;
using WMS.Model.Dtos.Urun;
using WMS.Model.Entities;

namespace WMS.Business.Implementations
{
    public class UrunBs : IUrunBs
    {
        private readonly IUrunRepository _repo;
        private readonly IMapper _mapper;
        public UrunBs(IUrunRepository repo, IMapper mapper) {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<ApiResponse<NoData>> DeleteAsync(int id)
        {
            if (id <= 0)
                throw new BadRequestException("id değeri 0 dan büyük olmalıdır");

            var urun = await _repo.IdGoreGetir(id);
            await _repo.DeleteAsync(urun);

            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }

        public async Task<ApiResponse<List<UrunGetDto>>> GetUrunlerAsync(params string[] includeList)
        {
            var urunler = await _repo.GetAllAsync(includeList: includeList);
            if (urunler.Count > 0)
            {
                var returnList = _mapper.Map<List<UrunGetDto>>(urunler);
                var response = ApiResponse<List<UrunGetDto>>.Success(StatusCodes.Status200OK, returnList);
                return response;
            }
            throw new NotFoundException("İçerik Bulunamadı");
        }

        public async Task<ApiResponse<UrunGetDto>> IdGoreUrunGetirAsync(int urunId, params string[] includeList)
        {
            if (urunId <= 0)
                throw new BadRequestException("id değeri 0 dan büyük olmalıdır");

            var urun = await _repo.IdGoreGetir(urunId, includeList);
            if (urun != null)
            {
                var dto = _mapper.Map<UrunGetDto>(urun);
                return ApiResponse<UrunGetDto>.Success(StatusCodes.Status200OK, dto);
            }

            throw new NotFoundException("İçerik Bulunamadı");
        }

        public async Task<ApiResponse<Urun>> InsertAsync(UrunPostDto dto)
        {
            if (dto == null)
                throw new BadRequestException("Kaydedilecek ürün bilgisi girmelisiniz..");

            var urun = _mapper.Map<Urun>(dto);

            var insertedUrun = await _repo.InsertAsync(urun);
            return ApiResponse<Urun>.Success(StatusCodes.Status201Created, insertedUrun);
        }

        public async Task<ApiResponse<List<UrunGetDto>>> IsimGoreUrunGetirAsync(string adi, params string[] includeList)
        {
            if (adi.Length < 2)
                throw new BadRequestException("İsim en az 3 harften oluşmalıdır");

            var urunler = await _repo.IsmeGoreGetir(adi, includeList);
            if (urunler.Count > 0 && urunler != null)
            {
                var returnList = _mapper.Map<List<UrunGetDto>>(urunler);
                return ApiResponse<List<UrunGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı");
        }

        public Task<ApiResponse<List<UrunGetDto>>> KayitTariheGoreUrunGetirAsync(DateTime baslangicTarihi, DateTime bitisTarihi, params string[] includeList)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<NoData>> UpdateAsync(UrunPutDto entity)
        {
            if (dto == null)
                throw new BadRequestException("Güncellenecek ürün bilgisi girmelisiniz..");

            if (dto.BlokAdi.Length < 2)
                throw new BadRequestException("Blok ismi en az 3 harften oluşmalıdır..");

            var blok = _mapper.Map<Blok>(dto);
            await _repo.UpdateAsync(blok);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
