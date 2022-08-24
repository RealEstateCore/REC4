[Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Temperature_Setpoint](../Temperature_Setpoint.md) > [Radiant_Panel_Temperature_Setpoint](.)
# Radiant_Panel_Temperature_Setpoint

**Display name:** Radiant Panel Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Radiant_Panel_Temperature_Setpoint;1

---


## Child interfaces
* [Inside_Face_Surface_Temperature_Setpoint](Inside_Face_Surface_Temperature_Setpoint.md)
* [Outside_Face_Surface_Temperature_Setpoint](Outside_Face_Surface_Temperature_Setpoint.md)
* [Embedded_Temperature_Setpoint](Embedded_Temperature_Setpoint/Embedded_Temperature_Setpoint.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
