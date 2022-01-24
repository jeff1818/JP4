import os
import wget
from zipfile import ZipFile


#Função barra
def bar_custom(current, total, width=80):
    print("Downloading: %d%% [%d / %d] bytes" % (current / total * 100, current, total))

#----------------------------------------------

remote_url = 'https://onedrive.live.com/download?cid=37ABC5C967094270&resid=37ABC5C967094270%2143546&authkey=ALBey4pELk566qg'
local_file = 'C:/JP4/JP4_setup/JP4_setup.zip'
wget.download(remote_url, local_file, bar=bar_custom)


#............................................

#with ZipFile('C:/GM4/GM4_setup.zip', 'r') as zip:
 #   zip.extractall('C:/GM4/Setup')


zf = ZipFile('C:/JP4/JP4_setup/JP4_setup.zip', 'r')
zf.extractall('C:/JP4/JP4_setup')
zf.close()

os.remove('C:\JP4\JP4_setup\JP4_setup.zip')
