SELECT p.Name, c.Name 
FROM products p LEFT JOIN products_categories pc ON p.Id = pc.p_id 
LEFT JOIN categories c on c.Id = pc.c_id;