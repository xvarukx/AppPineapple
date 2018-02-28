import sys
import argparse as ap
from PIL import Image as I
from PIL import ImageFile

try:
    ImageFile.LOAD_TRUNCATED_IMAGES = True
    ImageFile.LOAD_TRUNCATED_IMAGES = True
    I.MAX_IMAGE_PIXELS = None 
    
    filepath=sys.argv[1]
    outpath = sys.argv[2]
    
    fd_img = open(filepath,'rb')
    img = I.open(fd_img)
    width, height = img.size
    while (width > 2160) and (height > 3840):
        a = width-100
        b = height-100
        width = a
        height = b
    img.thumbnail((width,height), I.ANTIALIAS)
    img.save(outpath,'JPEG', quality=10)
    fd_img.close()
    img.close()
    print ("true")
except IOError:
    print ("false")