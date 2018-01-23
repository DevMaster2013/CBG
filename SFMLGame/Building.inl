template<typename T>
T* Building::getComponent()
{
	for (size_t i = 0; i < components.size(); i++)
	{
		if (typeid(components[i]) == typeid(T))
			return (T*)components[i];
	}
	return nullptr;
}
