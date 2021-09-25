﻿using Catalogue_Produit_App.DAO;
using Catalogue_Produit_App.DTO;
using Catalogue_Produit_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalogue_Produit_App.Service
{
    public class CategorieService : ICategorieService

    {


        public CategorieService()
        {

        }
        private readonly ICategorieRepository _categorieRepository;
        public CategorieService(ICategorieRepository categorieRepository)
        {
            _categorieRepository = categorieRepository;
        }

        public void AddNewCategorie(CategorieDto categorie)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategorie(int codeCategorie)
        {
            throw new NotImplementedException();
        }

        public List<CategorieDto> GetAllCategories()
        {
           
                List<CategorieDto> listCategorieDto = new List<CategorieDto>();         
                List<CAT_CATEGORIE> listCategories = new List<CAT_CATEGORIE>();
                listCategories = _categorieRepository.GetAllCategories();

                foreach(CAT_CATEGORIE item in listCategories)
                {
                    CategorieDto categorieDto = new CategorieDto();
                    categorieDto.codeCategorie = item.CODE_CATEGORIE;
                    categorieDto.libelleCategorie = item.LIBELLE_CATEGORIE;
                    categorieDto.dateSaisie = (DateTime)item.DATE_SAISIE;
                    listCategorieDto.Add(categorieDto);
                }

                return listCategorieDto;
          
           
        }

        public CategorieDto GetGategorieById(int codeCategorie)
        {
            throw new NotImplementedException();
        }

        public CategorieDto UpdateCategorie(int codeCategorie, CategorieDto categorie)
        {
            throw new NotImplementedException();
        }
    }
}