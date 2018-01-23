template<typename T>
T* Building::getComponent()
{
	std::string compType = std::string(typeid(T).name());
	if (components.find(compType) == components.end())
		return nullptr;
	return (T*)components[compType];
}

template<typename T>
void Building::addComponent(T* component)
{
	std::string comType = std::string(typeid(T).name());
	components[comType] = component;
}