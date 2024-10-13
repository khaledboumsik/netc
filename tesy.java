from abc import abstractclassmethod
class person:
    def __init__(self,name,surname):
        self._name=name
        self._surname=surname
        pass
    @property
    def Name(self):
        return self._name
    @Name.setter
    def Name(self,value):
        self._name=value
    @abstractclassmethod
    def move(self):
        pass