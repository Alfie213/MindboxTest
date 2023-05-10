SELECT Product.name as NameProduct, Category.name as NameCategory
FROM Product
LEFT JOIN Category ON Product.id_category = Category.id