extends Control


func _on_VisualScript_pressed():
	get_tree().change_scene("res://Visual/GameVisualScript.tscn")


func _on_GodotScript_pressed():
	get_tree().change_scene("res://GDScript/GameGDScript.tscn")
