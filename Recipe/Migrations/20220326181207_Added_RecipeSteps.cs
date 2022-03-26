using Microsoft.EntityFrameworkCore.Migrations;

namespace EatingMyEmpire.Api.Migrations
{
    public partial class Added_RecipeSteps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RecipeStep",
                columns: new[] { "id", "Ingredients", "Instructions" },
                values: new object[] { 1, "2 lbs chicken cut into serving pieces, 3 pieces dried bay leaves, 8 tablespoons soy sauce, 4 tablespoons white vinegar, 5 cloves garlic crushed, 1 1 / 2 cups water, 3 tablespoons cooking oil, 1 teaspoon sugar, 1 / 4 teaspoon salt optional, 1 teaspoon whole peppercorn", "1. Combine chicken, soy sauce, and garlic in a large bowl. Mix well. Marinate the chicken for at least 1 hour. Note: the longer the time, the better, 2.Heat a cooking pot. Pour cooking oil. 3.When the oil is hot enough, pan-fry the marinated chicken for 2 minutes per side. 4.Pour-in the remaining marinade, including garlic. Add water. Bring to a boil. 5.Add dried bay leaves and whole peppercorn. Simmer for 30 minutes or until the chicken gets tender. 6. Add vinegar. Stir and cook for 10 minutes. 7. Put-in the sugar, and salt. Stir and turn the heat off.Serve hot. Share and Enjoy!" });

            migrationBuilder.InsertData(
                table: "RecipeStep",
                columns: new[] { "id", "Ingredients", "Instructions" },
                values: new object[] { 2, "1 ½ lbs. pork belly boiled for 1 hour, ½ cup Lady’s Choice Mayonnaise, 2 pieces onion chopped, 4 pieces Thai chili pepper chopped, 2 pieces long green pepper chopped, 16 grams Knorr SavorRich Pork equivalent to 1 sachet, ½ teaspoon ground black pepper, 2 tablespoons soy sauce,¼ cup margarine, 2 cups cooking oil", "1. Heat oil in a deep cooking pot or deep fryer. Fry the boiled pork belly until golden brown and crispy. Chop the crispy pork belly into small pieces. Set aside. 2. Heat half of the margarine in a pan. Sauté half of the onions until soft. Add chopped pork. Saute for 30 seconds. 3. Add Knorr SavorRich. Stir and then add chili peppers and season with ground black pepper and soy sauce.Cook for 1 minute. 4. Add 'Lady’s Choice' Mayonnaise. Stir and add remaining onion. Set aside. 5. Heat a metal plate(sizzling plate) on a stovetop. Melt remaining margarine. Transfer the crispy pork sisig into the metal plate. Let it stay for 30 seconds. 6. Serve with warm rice and your favorite beverage. Enjoy!" });

            migrationBuilder.InsertData(
                table: "RecipeStep",
                columns: new[] { "id", "Ingredients", "Instructions" },
                values: new object[] { 3, "4 tbsp vegetable oil, 25g butter, 4 onions roughly chopped, 6 tbsp chicken tikka masala paste(use shop - bought or make your own – see recipe, below), 2 red peppers deseeded and cut into chunks, 8 boneless, skinless chicken breasts, cut into 2.5cm cubes, 2 x 400g cans chopped tomatoes,4 tbsp tomato purée, 2 - 3 tbsp mango chutney,150ml double cream,150ml natural yogurt, chopped coriander leaves to serve", "1. Heat the vegetable oil and butter in a large, lidded casserole on the hob, then add the onions and a pinch of salt. Cook for 15-20 mins until soft and golden. 2. Add the tikka masala paste and peppers, then cook for 5 mins more to cook out the rawness of the spices. 3. Add the chicken breasts and stir well to coat in the paste. Cook for 2 mins, then tip in the chopped tomatoes, tomato purée and 200ml water. Cover with a lid and gently simmer for 15 mins, stirring occasionally, until the chicken is cooked through. 4. Remove the lid, stir through the mango chutney, double cream and natural yogurt, then gently warm through. Season, then set aside whatever you want to freeze. Will keep, in an airtight container, in the freezer for up to three months. Scatter the rest with coriander leaves and serve with basmati rice and naan bread." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeStep",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecipeStep",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecipeStep",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
