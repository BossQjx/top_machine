import tkinter
import random
import threading
import time

#初始化窗口
root=tkinter.Tk()
root.title("2121班随机抽奖")
root.geometry('500x550+400+200')  #geometry("widthxheight+x+y") x、y是窗口相对屏幕的坐标
root.resizable(False,False)  #禁止窗口拉伸     #resizable(width=True, height=True)width是宽，height为高，
                                             #默认的tk窗口是True真，即宽可变，高可变，也就是说width=True, height=True。
root.flag = True

#五个Lable标签
first = tkinter.Label(root,text='',font = ("宋体", 20,"normal"))
first.place(x=180,y=50,width=150,height=100)

second = tkinter.Label(root,text='',font = ("宋体", 20,"normal"))
second.place(x=180,y=150,width=150,height=100)

third = tkinter.Label(root,text='',font = ("宋体", 20,"normal"))
third['fg'] = 'red'
third.place(x=180,y=250,width=150,height=100)

fourth = tkinter.Label(root,text='',font = ("宋体", 20,"normal"))
fourth.place(x=180,y=350,width=150,height=100)

fifth = tkinter.Label(root,text='',font = ("宋体", 20,"normal"))
fifth.place(x=180,y=450,width=150,height=100)

#读取文件
def loadDataSet(filename):
	data = []
	fr = open(filename)
	for line in fr.readlines():
		lineArr = line.strip().split('	')
		print(lineArr)
		if lineArr[0] == '####':
			break
		else:
			s = lineArr[0] + ' ' + lineArr[1]
			data.append(s)
	return data

students = loadDataSet('2121班名单.txt')

def switch():
    root.flag=True
    while root.flag:
        i=random.randint(0, len(students)-1)
        first['text'] = second['text']
        second['text'] = third['text']
        third['text'] = fourth['text']
        fourth['text'] = fifth['text']
        fifth['text']=students[i]
        time.sleep(0.005)



#开始按钮
def butStartClick():
    t=threading.Thread(target=switch)
    t.start()
btnStart=tkinter.Button(root,text='开始',command=butStartClick)
btnStart.place(x=30, y=10, width=80, height=40)

#结束按钮
def btnStopClick():
    root.flag=False
    
butStop=tkinter.Button(root,text='停止',command=btnStopClick)
butStop.place(x=160, y=10, width=80, height=40)

#启动主程序
root.mainloop()

