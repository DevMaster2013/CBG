#include "ProductItem.h"
#include "Product.h"

#include <SFML\Graphics.hpp>
#include <imgui.h>
#include <imgui-SFML.h>

ProductItem::ProductItem(Product * product, double unitPrice, double quantity)
	: product(product)
	, unitPrice(unitPrice)
	, quantity(quantity)
{
}

void ProductItem::drawInterface()
{
#ifdef USE_SFGUI_INTERFACE
#else
	ImGui::Text("%2.2f tons of %s --> %2.2f pound", quantity, product->name.c_str(), quantity * unitPrice);
#endif
}
