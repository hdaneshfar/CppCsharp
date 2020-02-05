class FileReader:
	def ReadFile(self,filePath):
		f = open(filePath, "r")
		print(f.read()) 