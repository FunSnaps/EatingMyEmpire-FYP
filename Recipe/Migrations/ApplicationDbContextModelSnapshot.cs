﻿// <auto-generated />
using System;
using EatingMyEmpire.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EatingMyEmpire.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EatingMyEmpire.Shared.Recipe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseType")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipeDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecipeStepId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("RecipeStepId");

                    b.ToTable("Recipe");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CourseType = 0,
                            DateAdded = new DateTime(2022, 3, 31, 13, 38, 23, 400, DateTimeKind.Utc).AddTicks(5080),
                            PhotoPath = "images/adobo.jpg",
                            RecipeDescription = "Chicken Adobo is a type of Filipino chicken stew. Chicken pieces are marinated in soy sauce and spices, pan-fried, and stewed until tender. The dish gained popularity because of its delicious taste and ease in preparation.",
                            RecipeName = "Adobo",
                            RecipeStepId = 1
                        },
                        new
                        {
                            id = 2,
                            CourseType = 0,
                            DateAdded = new DateTime(2022, 3, 31, 13, 38, 23, 400, DateTimeKind.Utc).AddTicks(6005),
                            PhotoPath = "images/Sizzling-Sisig.jpg",
                            RecipeDescription = "Sizzling Crispy Sisig is a great dish to prepare during Christmas dinner or in any special occasion. It has a nice texture and the flavor is out-of-this-world. I enjoy having it for dinner with a cup of white rice. It can also be served as an appetizer along with a cold bottle or glass of your favorite drink.",
                            RecipeName = "Sizzling Sisig",
                            RecipeStepId = 2
                        },
                        new
                        {
                            id = 3,
                            CourseType = 0,
                            DateAdded = new DateTime(2022, 3, 31, 13, 38, 23, 400, DateTimeKind.Utc).AddTicks(6023),
                            PhotoPath = "images/Chicken-Tikka-Masala.jpg",
                            RecipeDescription = "This rich and creamy flavoursome Chicken tikka rivals any Indian restaurant! Why go out when you can make it better at home! With aromatic golden chicken pieces swimming in an incredible curry sauce, this Chicken Tikka Masala recipe is one of the best you will try! Pair it with our buttery garlic naan breads!",
                            RecipeName = "Chicken Tikka Masala",
                            RecipeStepId = 3
                        });
                });

            modelBuilder.Entity("EatingMyEmpire.Shared.RecipeStep", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("RecipeStep");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Ingredients = "2 lbs chicken cut into serving pieces, 3 pieces dried bay leaves, 8 tablespoons soy sauce, 4 tablespoons white vinegar, 5 cloves garlic crushed, 1 1 / 2 cups water, 3 tablespoons cooking oil, 1 teaspoon sugar, 1 / 4 teaspoon salt optional, 1 teaspoon whole peppercorn",
                            Instructions = "1. Combine chicken, soy sauce, and garlic in a large bowl. Mix well. Marinate the chicken for at least 1 hour. Note: the longer the time, the better, 2.Heat a cooking pot. Pour cooking oil. 3.When the oil is hot enough, pan-fry the marinated chicken for 2 minutes per side. 4.Pour-in the remaining marinade, including garlic. Add water. Bring to a boil. 5.Add dried bay leaves and whole peppercorn. Simmer for 30 minutes or until the chicken gets tender. 6. Add vinegar. Stir and cook for 10 minutes. 7. Put-in the sugar, and salt. Stir and turn the heat off.Serve hot. Share and Enjoy!"
                        },
                        new
                        {
                            id = 2,
                            Ingredients = "1 ½ lbs. pork belly boiled for 1 hour, ½ cup Lady’s Choice Mayonnaise, 2 pieces onion chopped, 4 pieces Thai chili pepper chopped, 2 pieces long green pepper chopped, 16 grams Knorr SavorRich Pork equivalent to 1 sachet, ½ teaspoon ground black pepper, 2 tablespoons soy sauce,¼ cup margarine, 2 cups cooking oil",
                            Instructions = "1. Heat oil in a deep cooking pot or deep fryer. Fry the boiled pork belly until golden brown and crispy. Chop the crispy pork belly into small pieces. Set aside. 2. Heat half of the margarine in a pan. Sauté half of the onions until soft. Add chopped pork. Saute for 30 seconds. 3. Add Knorr SavorRich. Stir and then add chili peppers and season with ground black pepper and soy sauce.Cook for 1 minute. 4. Add 'Lady’s Choice' Mayonnaise. Stir and add remaining onion. Set aside. 5. Heat a metal plate(sizzling plate) on a stovetop. Melt remaining margarine. Transfer the crispy pork sisig into the metal plate. Let it stay for 30 seconds. 6. Serve with warm rice and your favorite beverage. Enjoy!"
                        },
                        new
                        {
                            id = 3,
                            Ingredients = "4 tbsp vegetable oil, 25g butter, 4 onions roughly chopped, 6 tbsp chicken tikka masala paste(use shop - bought or make your own – see recipe, below), 2 red peppers deseeded and cut into chunks, 8 boneless, skinless chicken breasts, cut into 2.5cm cubes, 2 x 400g cans chopped tomatoes,4 tbsp tomato purée, 2 - 3 tbsp mango chutney,150ml double cream,150ml natural yogurt, chopped coriander leaves to serve",
                            Instructions = "1. Heat the vegetable oil and butter in a large, lidded casserole on the hob, then add the onions and a pinch of salt. Cook for 15-20 mins until soft and golden. 2. Add the tikka masala paste and peppers, then cook for 5 mins more to cook out the rawness of the spices. 3. Add the chicken breasts and stir well to coat in the paste. Cook for 2 mins, then tip in the chopped tomatoes, tomato purée and 200ml water. Cover with a lid and gently simmer for 15 mins, stirring occasionally, until the chicken is cooked through. 4. Remove the lid, stir through the mango chutney, double cream and natural yogurt, then gently warm through. Season, then set aside whatever you want to freeze. Will keep, in an airtight container, in the freezer for up to three months. Scatter the rest with coriander leaves and serve with basmati rice and naan bread."
                        });
                });

            modelBuilder.Entity("EatingMyEmpire.Shared.Recipe", b =>
                {
                    b.HasOne("EatingMyEmpire.Shared.RecipeStep", "RecipeStep")
                        .WithMany()
                        .HasForeignKey("RecipeStepId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("RecipeStep");
                });
#pragma warning restore 612, 618
        }
    }
}
