@echo off

:: utf-8
Chcp 65001>nul

set program=MindFlow

:: 发布目录
set publish_path=..\publish

:: 发布目录下的模块项目目录
set publish_modules_path=%publish_path%\Modules

:: 1.删除原发布目录
if exist %publish_path% (
    del /s/q %publish_path%\*.*
    rd /s/q %publish_path%
)

:: 2.检测文件夹
if not exist %publish_modules_path%\ md %publish_modules_path%\

:: 3.发布
dotnet publish -c Release --no-self-contained -o %publish_path%\ ..\%program%.sln

:: 4.分类
move /y %publish_path%\%program%.Module.* %publish_modules_path%\

@IF %ERRORLEVEL% NEQ 0 pause