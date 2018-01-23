#pragma once

#include "IDrawableInterfaceObject.h"

class Product;
class ProductItem : public IDrawableInterfaceObject
{
public:
	Product* product;
	double unitPrice;
	double quantity;

public:
	ProductItem(Product* product, double unitPrice, double quantity = 0);

public:
	virtual void drawInterface() override;
};