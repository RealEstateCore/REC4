[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Pressure_Sensor](../Pressure_Sensor.md) > [Velocity_Pressure_Sensor](Velocity_Pressure_Sensor.md) > [Exhaust_Air_Velocity_Pressure_Sensor](.)
# Exhaust_Air_Velocity_Pressure_Sensor

**Display name:** Exhaust Air Velocity Pressure Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Exhaust_Air_Velocity_Pressure_Sensor;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
