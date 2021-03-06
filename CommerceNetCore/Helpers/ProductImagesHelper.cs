﻿using CommerceNetCore.Data;
using CommerceNetCore.Models;
using CommerceNetCore.Repositories.ProductImages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceNetCore.Helpers
{
    public class ProductImagesHelper
    {
        protected CommerceDbContext _commerceDbContext;

        private IHostingEnvironment _hostingEnvironment;
        public ProductImagesHelper(CommerceDbContext commerceDbContext, IHostingEnvironment hostingEnvironment)
        {
            _commerceDbContext = commerceDbContext;
            _hostingEnvironment = hostingEnvironment;
        }

        public void SaveProductImage(List<IFormFile> formFiles, int productId)
        {
            ProductImageRepository imageRepository = new ProductImageRepository(_commerceDbContext);

            List<ProductImage> productImages = new List<ProductImage>();
            string shortLocation = $"\\images\\products\\{productId}\\";
            string uploads = Path.Combine(_hostingEnvironment.WebRootPath + shortLocation);
            if (!Directory.Exists(uploads))
            {
                DirectoryInfo di = Directory.CreateDirectory(uploads);
            }
            foreach (var file in formFiles)
            {
                //string fileName = file.FileName;
               
                if (file.Length > 0)
                {
                    //item.CopyTo(fileStream);
                    var filePath = Path.Combine(uploads, file.FileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    ProductImage product = new ProductImage();
                    product.Path = $"/images/products/{productId}/{file.FileName}";
                    product.ProductId = productId;
                    product.UploadDate = DateTime.Now;
                    imageRepository.Create(product);
                }
            }
        }
    }
}
