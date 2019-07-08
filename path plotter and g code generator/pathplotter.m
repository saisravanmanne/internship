

function varargout = pathplotter(varargin)
% PATHPLOTTER MATLAB code for pathplotter.fig
%      PATHPLOTTER, by itself, creates a new PATHPLOTTER or raises the existing
%      singleton*.
%
%      H = PATHPLOTTER returns the handle to a new PATHPLOTTER or the handle to
%      the existing singleton*.
%
%      PATHPLOTTER('CALLBACK',hObject,eventData,handles,...) calls the local
%      function named CALLBACK in PATHPLOTTER.M with the given input arguments.
%
%      PATHPLOTTER('Property','Value',...) creates a new PATHPLOTTER or raises the
%      existing singleton*.  Starting from the left, property value pairs are
%      applied to the GUI before pathplotter_OpeningFcn gets called.  An
%      unrecognized property name or invalid value makes property application
%      stop.  All inputs are passed to pathplotter_OpeningFcn via varargin.
%
%      *See GUI Options on GUIDE's Tools menu.  Choose "GUI allows only one
%      instance to run (singleton)".
%
% See also: GUIDE, GUIDATA, GUIHANDLES

% Edit the above text to modify the response to help pathplotter

% Last Modified by GUIDE v2.5 09-Jul-2015 11:32:33

% Begin initialization code - DO NOT EDIT
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @pathplotter_OpeningFcn, ...
                   'gui_OutputFcn',  @pathplotter_OutputFcn, ...
                   'gui_LayoutFcn',  [] , ...
                   'gui_Callback',   []);
if nargin && ischar(varargin{1})
    gui_State.gui_Callback = str2func(varargin{1});
end

if nargout
    [varargout{1:nargout}] = gui_mainfcn(gui_State, varargin{:});
else
    gui_mainfcn(gui_State, varargin{:});
end
% End initialization code - DO NOT EDIT


% --- Executes just before pathplotter is made visible.
function pathplotter_OpeningFcn(hObject, eventdata, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to pathplotter (see VARARGIN)

% Choose default command line output for pathplotter
handles.output = hObject;

% Update handles structure
guidata(hObject, handles);

% UIWAIT makes pathplotter wait for user response (see UIRESUME)
% uiwait(handles.figure1);


% --- Outputs from this function are returned to the command line.
function varargout = pathplotter_OutputFcn(hObject, eventdata, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure
varargout{1} = handles.output;


% --- Executes on button press in pushbutton1.
function pushbutton1_Callback(hObject, eventdata, handles)
% hObject    handle to pushbutton1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
%clc
%clear all

syms x y x1 y1 x2 y2 r


a=[0 0 0 0]
tt=[0 0]
a(1)
a(1)=str2num(get(handles.x1,'String'))
a(2)=str2num(get(handles.y1,'String'))
a(3)=str2num(get(handles.x2,'String'))
a(4)=str2num(get(handles.y2,'String'))
tt(1)=str2num(get(handles.d1,'String'))
tt(2)=str2num(get(handles.d2,'String'))
x1=a(1)
y1=a(2)
x2=a(3)
y2=a(4)
distance=sqrt((x1-x2)^2+(y1-y2)^2)
l=distance/4
l=9
c1=[x1+l*cos(tt(1)-pi/2) y1+l*sin(tt(1)-pi/2)]
c2=[x2+l*cos(tt(2)-pi/2) y2+l*sin(tt(2)-pi/2)]

slope=atan((c2(2)-c1(2))/(c2(1)-c1(1)))
atan(inf)
c11=[c1(1)+l*cos(slope+pi/2) c1(2)+l*sin(slope+pi/2)]
sin(slope+pi/2)
k=0
p=0
c1(1)-9

c12=[c1(1)-l*cosd((slope+pi/2)*180/pi) c1(2)-l*sind((slope+pi/2)*180/pi)]
c21=[c2(1)+l*cos(slope+pi/2) c2(2)+l*sin(slope+pi/2)]
c22=[c2(1)-l*cos(slope+pi/2) c2(2)-l*sin(slope+pi/2)]
man=fopen('gcode.txt','w')
l
g1=[0 0]
g2=[0 0]
if (c2(1))>(c1(1))
    
    if c11(2)>c12(2)
        g1=c11
        g1z=c12
    end
    if c12(2)>c11(2)
        g1=c12
        g1z=c11
    end
     if c21(2)>c22(2)
        g2=c21
        g2z=c22
    end
    if c22(2)>c21(2)
        g2=c22
        g2z=c21
    end
    
end
if (c1(1))>(c2(1))
    
    if c11(2)>c12(2)
        g1=c12
        g1z=c11
    end
    if c12(2)>c11(2)
        g1=c11
        g1z=c12
    end
     if c21(2)>=c22(2)
        g2=c22
        g2z=c21
    end
    if c22(2)>c21(2)
        g2=c21
        g2z=c22
    end
end
g1
g2

if tt(1)==tt(2)
    if (c1(1)==c2(1))&&(c1(2)<c2(2))
        p=1
    if c11(1)<c12(1)
        g1=c11
        g1z=c12
    else
        g1=c12
    end
    if c21(1)<c22(1)
        g2=c21
    else
        g2=c22
    end
    end
        
    
    if (c1(1)==c2(1))&&(c1(2)>c2(2))
        p=1
        if c11(1)>c12(1)
            g1=c11
        else
            g1=c12
        end
        if c21(1)>c22(1)
            g2=c21
        else
            g2=c22
    end
    end

    if (c1(2)==c2(2))&&(c1(1)<c2(1))
        if c11(2)>c12(2)
            g1=c11
        else
            g1=c12

        end
        if c21(2)>c22(2)
            g2=c21
        else
            g2=c22
        end
    end
    
    if (c1(2)==c2(2))&&(c1(1)>c2(1))
        if c11(2)<c12(2)
            g1=c11
        else
            g1=c12
        end
        if c21(2)<c22(2)
            g2=c21
        else
            g2=c22
        end
    end
   
end
distance1=sqrt((a(1)-g1(1))^2+(a(2)-g1(2))^2)
distance1=distance1/2
angle1=2*asin(distance1/l)*180/pi
hold
distance2=sqrt((a(3)-g2(1))^2+(a(4)-g2(2))^2)
distance2=distance2/2
angle2=2*asin(distance2/l)*180/pi
if (c2(2)>c1(2))&&(c2(1)>c1(1))
    if (a(2)>g1z(2))&&(a(1)>g1(1))
        angle1=360-angle1
    else
        angle1=angle1
    end
    if (a(4)<g2(2))&&(a(3)<g2z(1))
        angle2=360-angle2
    else
        angle2=angle2
    end
    k=1
end


if (c2(1)>c1(1))&&(c2(2)<c1(2))
    if (a(2)<g1(2))&&(a(1)>g1z(1))
        angle1=360-angle1
    else
        angle1=angle1
    end
    if (a(4)>g2z(2))&&(a(3)<g2(1))
        angle2=360-angle2
    else
        angle1=angle1
    end
    k=1
end


if (c1(1)>c2(1))&&(c1(2)<c2(2))
    if (a(2)>g1(2))&&(a(1)<g1z(1))
        angle1=360-angle1
    else 
        angle1=angle1
    end
    if (a(4)<g2z(2))&&(a(3)>g2(1))
        angle2=360-angle2
    else
        angle2=angle2
    end
    k=1
end

if (c1(1)>c2(1))&&(c1(2)>c2(2))
    if (a(2)<g1z(2))&&(a(1)<g1(1))
        angle1=360-angle1
    else
        angle1=angle1
    end
    if (a(4)>g2(2))&&(a(3)>g2z(1))
        angle2=360-angle2
    else
        angle2=angle2
    end
    k=1
end

       


g1
g2
if k==0
    angle1=0
    angle2=0
end
angle1=abs(angle1)
angle2=abs(angle2)
distanceG=sqrt((g1(1)-g2(1))^2+(g1(2)-g2(2))^2)
fprintf(man,'G91 \r\nM03 \r\n')
%fprintf(man,'G00  X%f  Y%f \r\n',a(1),a(2))
fprintf(man,'G01  X-%f  Y%f  F8000\r\n',angle1/360*2*pi*18*10,0)
fprintf(man,'G01  X-%f  Y%f \r\n',distanceG*10,distanceG*10)
fprintf(man,'G01  X-%f  Y%f \r\nM05\r\nM02\r\n',angle2/360*2*pi*18*10,0)
%angle11=atan((c1(2)-g1(2))/(c1(1)-g1(1)))*180/pi
%angle12=atan((c1(2)-a(2))/(c1(1)-a(1)))*180/pi
%if angle11<0
    %angle11=180+angle11
%end
%if angle12<0
   % angle12=180+angle12
%end a=add(c,d)



%angle21=atan((c2(2)-g2(2))/(c2(1)-g2(1)))*180/pi
%angle22=atan((c2(2)-a(4))/(c2(1)-a(3)))*180/pi
%if (a(2)>c1(2))&&(g1(2)>c1(2))
 %   anglef1=(angle11-angle12)
%end
%    anglef1=(angle11-angle12)
tt(1)=tt(1)*180/pi
tt(1)=tt(1)+90
tt(1)
tt(1)-angle1
teta1=tt(1)-angle1:1:tt(1);
x=c1(1)+9*cosd(teta1);
y=c1(2)+9*sind(teta1);
plot(x,y)
axis([-100 100 -100 100])

if p==1
    x=a(1)
    m1=min(a(2),a(4))
    m2=max(a(2),a(4))
    y=m1:0.5:m2+0.5
    plot(x,y)
    axis([-100 100 -100 100])
else
slope=tan(slope)
 t1=max(g1(1),g2(1))
 t2=min(g1(1),g2(1))
 x=t2:0.5:t1+0.5
y=g1(2)+slope*(x-g1(1))
plot(x,y)
axis([-100 100 -100 100])
end

if c1(1)<c2(1)
    slope=atan(slope)
slope=slope*180/pi
tt(2)=tt(2)*180/pi
teta2=slope+90-angle2:1:slope+90
x=c2(1)+9*cosd(teta2)
y=c2(2)+9*sind(teta2)
plot(x,y)
axis([-100 100 -100 100])
end


if c1(1)>c2(1)
    slope=atan(slope)
slope=slope*180/pi
tt(2)=tt(2)*180/pi
teta2=slope-90-angle2:1:slope-90
x=c2(1)+9*cosd(teta2)
y=c2(2)+9*sind(teta2)
plot(x,y)
axis([-100 100 -100 100])
end
k
hold off








% --- Executes on button press in radiobutton1.
function radiobutton1_Callback(hObject, eventdata, handles)
% hObject    handle to radiobutton1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hint: get(hObject,'Value') returns toggle state of radiobutton1



function edit1_Callback(hObject, eventdata, handles)
% hObject    handle to edit1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of edit1 as text
%        str2double(get(hObject,'String')) returns contents of edit1 as a double


% --- Executes during object creation, after setting all properties.
function edit1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to edit1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


% --- Executes on selection change in popupmenu1.
function popupmenu1_Callback(hObject, eventdata, handles)
% hObject    handle to popupmenu1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: contents = cellstr(get(hObject,'String')) returns popupmenu1 contents as cell array
%        contents{get(hObject,'Value')} returns selected item from popupmenu1


% --- Executes during object creation, after setting all properties.
function popupmenu1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to popupmenu1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: popupmenu controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


% --- Executes on selection change in listbox1.
function listbox1_Callback(hObject, eventdata, handles)
% hObject    handle to listbox1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: contents = cellstr(get(hObject,'String')) returns listbox1 contents as cell array
%        contents{get(hObject,'Value')} returns selected item from listbox1


% --- Executes during object creation, after setting all properties.
function listbox1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to listbox1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: listbox controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end



function y1_Callback(hObject, eventdata, handles)
% hObject    handle to y1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of y1 as text
%        str2double(get(hObject,'String')) returns contents of y1 as a double


% --- Executes during object creation, after setting all properties.
function y1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to y1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end



function x1_Callback(hObject, eventdata, handles)
% hObject    handle to x1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of x1 as text
%        str2double(get(hObject,'String')) returns contents of x1 as a double


% --- Executes during object creation, after setting all properties.
function x1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to x1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end



function x2_Callback(hObject, eventdata, handles)
% hObject    handle to x2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of x2 as text
%        str2double(get(hObject,'String')) returns contents of x2 as a double


% --- Executes during object creation, after setting all properties.
function x2_CreateFcn(hObject, eventdata, handles)
% hObject    handle to x2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end



function y2_Callback(hObject, eventdata, handles)
% hObject    handle to y2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of y2 as text
%        str2double(get(hObject,'String')) returns contents of y2 as a double


% --- Executes during object creation, after setting all properties.
function y2_CreateFcn(hObject, eventdata, handles)
% hObject    handle to y2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end



function d1_Callback(hObject, eventdata, handles)
% hObject    handle to d1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of d1 as text
%        str2double(get(hObject,'String')) returns contents of d1 as a double


% --- Executes during object creation, after setting all properties.
function d1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to d1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end



function d2_Callback(hObject, eventdata, handles)
% hObject    handle to d2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of d2 as text
%        str2double(get(hObject,'String')) returns contents of d2 as a double


% --- Executes during object creation, after setting all properties.
function d2_CreateFcn(hObject, eventdata, handles)
% hObject    handle to d2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


% --- Executes on button press in pushbutton3.
function pushbutton3_Callback(hObject, eventdata, handles)
% hObject    handle to pushbutton3 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
x=0
y=0
hold off
plot(x,y)
axis([-100 100 -100 100])
